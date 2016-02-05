﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Sarif.SarifValidator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Sarif.SarifValidator.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft (R) SARIF Validator version {0}.
        /// </summary>
        internal static string Banner {
            get {
                return ResourceManager.GetString("Banner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright (C) Microsoft Corporation. All rights reserved..
        /// </summary>
        internal static string Copyright {
            get {
                return ResourceManager.GetString("Copyright", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: {0}.
        /// </summary>
        internal static string Exception {
            get {
                return ResourceManager.GetString("Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file contains {0} errors..
        /// </summary>
        internal static string FileContainsErrors {
            get {
                return ResourceManager.GetString("FileContainsErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON schema validation error: {0}.
        /// </summary>
        internal static string JsonSchemaValidationErrorMessageFormat {
            get {
                return ResourceManager.GetString("JsonSchemaValidationErrorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file contains a JSON schema validation error..
        /// </summary>
        internal static string JsonSchemaValidationErrorRuleDescription {
            get {
                return ResourceManager.GetString("JsonSchemaValidationErrorRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to JSON syntax error: {0}.
        /// </summary>
        internal static string JsonSyntaxErrorMessageFormat {
            get {
                return ResourceManager.GetString("JsonSyntaxErrorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file contains a JSON syntax error..
        /// </summary>
        internal static string JsonSyntaxErrorRuleDescription {
            get {
                return ResourceManager.GetString("JsonSyntaxErrorRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file is syntactically correct and valid according to the schema..
        /// </summary>
        internal static string Success {
            get {
                return ResourceManager.GetString("Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error kind: {0}.
        /// </summary>
        internal static string UnknownErrorMessageFormat {
            get {
                return ResourceManager.GetString("UnknownErrorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The JSON validator reported an error of an unknown kind..
        /// </summary>
        internal static string UnknownErrorRuleDescription {
            get {
                return ResourceManager.GetString("UnknownErrorRuleDescription", resourceCulture);
            }
        }
    }
}