﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExtenFlow.Infrastructure.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExtenFlow.Infrastructure.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The email should have two parts, seperated by &apos;@&apos;. Email=&apos;{0}&apos;..
        /// </summary>
        internal static string EmailShouldHaveTwoParts {
            get {
                return ResourceManager.GetString("EmailShouldHaveTwoParts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email domain name is not defined..
        /// </summary>
        internal static string EmailUndefinedDomainName {
            get {
                return ResourceManager.GetString("EmailUndefinedDomainName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email user name is not defined..
        /// </summary>
        internal static string EmailUndefinedUserName {
            get {
                return ResourceManager.GetString("EmailUndefinedUserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty string values are not supported..
        /// </summary>
        internal static string EmptyStringValueNotSupported {
            get {
                return ResourceManager.GetString("EmptyStringValueNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can&apos;t be retreived from a failed result..
        /// </summary>
        internal static string FailedResultValueAccess {
            get {
                return ResourceManager.GetString("FailedResultValueAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while writing to memory..
        /// </summary>
        internal static string MemoryWriteError {
            get {
                return ResourceManager.GetString("MemoryWriteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The failed result does not contain failure messages..
        /// </summary>
        internal static string MissingFailureMessages {
            get {
                return ResourceManager.GetString("MissingFailureMessages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The result contains a null value..
        /// </summary>
        internal static string ResultValueIsNull {
            get {
                return ResourceManager.GetString("ResultValueIsNull", resourceCulture);
            }
        }
    }
}
