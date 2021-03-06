﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExtenFlow.Identity.Roles.Domain.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExtenFlow.Identity.Roles.Domain.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate normalized role name. .
        /// </summary>
        public static string DuplicateNormalizedRoleName {
            get {
                return ResourceManager.GetString("DuplicateNormalizedRoleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate role with &apos;{0}&apos;=&apos;{1}&apos;..
        /// </summary>
        public static string DuplicateRole {
            get {
                return ResourceManager.GetString("DuplicateRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid role name : &apos;{0}&apos;..
        /// </summary>
        public static string InvalidRoleName {
            get {
                return ResourceManager.GetString("InvalidRoleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid role normalized name : &apos;{0}&apos;..
        /// </summary>
        public static string InvalidRoleNormalizedName {
            get {
                return ResourceManager.GetString("InvalidRoleNormalizedName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Normalized.
        /// </summary>
        public static string Normalized {
            get {
                return ResourceManager.GetString("Normalized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Normalized name.
        /// </summary>
        public static string NormalizedName {
            get {
                return ResourceManager.GetString("NormalizedName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The normalized name is used to find a role or to identify duplicate names. It&apos;s calculated by the system from the name..
        /// </summary>
        public static string NormalizedNameDescription {
            get {
                return ResourceManager.GetString("NormalizedNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The normalized role name is not defined..
        /// </summary>
        public static string NormalizedRoleNameNotDefined {
            get {
                return ResourceManager.GetString("NormalizedRoleNameNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The role claim type is not defined..
        /// </summary>
        public static string RoleClaimTypeNotDefined {
            get {
                return ResourceManager.GetString("RoleClaimTypeNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Concurrency check failure when updating the role in database. Expected stamp : &apos;{0}&apos;; Actual stamp : &apos;{1}&apos;..
        /// </summary>
        public static string RoleConcurrencyFailure {
            get {
                return ResourceManager.GetString("RoleConcurrencyFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The role concurrency stamp is not defined..
        /// </summary>
        public static string RoleConcurrencyStampNotDefined {
            get {
                return ResourceManager.GetString("RoleConcurrencyStampNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The role id is not defined.
        /// </summary>
        public static string RoleIdNotDefined {
            get {
                return ResourceManager.GetString("RoleIdNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The role name is not valid..
        /// </summary>
        public static string RoleNameInvalid {
            get {
                return ResourceManager.GetString("RoleNameInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The role name is not defined..
        /// </summary>
        public static string RoleNameNotDefined {
            get {
                return ResourceManager.GetString("RoleNameNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role with &apos;{0}&apos;=&apos;{1}&apos; not found..
        /// </summary>
        public static string RoleNotFound {
            get {
                return ResourceManager.GetString("RoleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role not initialized..
        /// </summary>
        public static string RoleNotInitialized {
            get {
                return ResourceManager.GetString("RoleNotInitialized", resourceCulture);
            }
        }
    }
}
