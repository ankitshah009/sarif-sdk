﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.CodeAnalysis.Sarif;
using Newtonsoft.Json;
using Xunit;

namespace Microsoft.CodeAnalysis.Sarif.FunctionalTests
{
    public class PropertyBagConverterTests
    {
        [Fact]
        [Trait(TestTraits.Bug, "https://github.com/microsoft/sarif-sdk/issues/1045")]
        public void PropertyBagConverter_RoundTripsStringPropertyWithEscapedCharacters()
        {
            string intPropertyName = nameof(intPropertyName);
            int intPropertyValue = 42;

            string stringPropertyName = nameof(stringPropertyName);
            string stringPropertyValue = "'\"\\'";

            string normalStringPropertyName = "source.language";
            string normalStringPropertyValue = "csharp";

            string dateTimePropertyName = "runStart";
            DateTime dateTimePropertyValue = DateTime.UtcNow.AddHours(-1.43);

            var run = new Run();
            run.SetProperty(intPropertyName, 42);
            run.SetProperty(stringPropertyName, stringPropertyValue);
            run.SetProperty(normalStringPropertyName, normalStringPropertyValue);
            run.SetProperty<DateTime>(dateTimePropertyName, dateTimePropertyValue);

            var originalLog = new SarifLog
            {
                Runs = new List<Run>
                {
                    new Run
                    {
                        Tool = new Tool
                        {
                            Driver = new ToolComponent
                            {
                                Name = "CodeScanner"
                            }
                        },
                        Properties = run.Properties
                    }
                }
            };

            string originalLogText = JsonConvert.SerializeObject(originalLog, Formatting.Indented);

            var settings = new JsonSerializerSettings { Formatting = Formatting.Indented };
            SarifLog deserializedLog = JsonConvert.DeserializeObject<SarifLog>(originalLogText);
            run = deserializedLog.Runs[0];

            int integerProperty = run.GetProperty<int>(intPropertyName);
            integerProperty.Should().Be(intPropertyValue);
            run.GetSerializedPropertyValue(intPropertyName).Should().Be(intPropertyValue.ToString());

            string stringProperty = run.GetProperty<string>(stringPropertyName);
            stringProperty.Should().Be(stringPropertyValue);
            run.GetSerializedPropertyValue(stringPropertyName).Should().Be("\"'\\\"\\\\'\"");

            run.GetProperty<string>(normalStringPropertyName).Should().Be(normalStringPropertyValue);

            run.GetProperty<DateTime>(dateTimePropertyName).Should().Be(dateTimePropertyValue);

            string reserializedLog = JsonConvert.SerializeObject(deserializedLog, settings);

            reserializedLog.Should().Be(originalLogText);
        }
    }
}
