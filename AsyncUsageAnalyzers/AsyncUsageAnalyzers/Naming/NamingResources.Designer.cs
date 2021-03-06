﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsyncUsageAnalyzers.Naming {
    using System;
    using System.Reflection;
    
    
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
    internal class NamingResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NamingResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AsyncUsageAnalyzers.Naming.NamingResources", typeof(NamingResources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Only methods which return a Task should include the suffix &apos;Async&apos;.
        /// </summary>
        internal static string AvoidAsyncSuffixDescription {
            get {
                return ResourceManager.GetString("AvoidAsyncSuffixDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-Task-returning method &apos;{0}&apos; should not end with &apos;Async&apos;.
        /// </summary>
        internal static string AvoidAsyncSuffixMessageFormat {
            get {
                return ResourceManager.GetString("AvoidAsyncSuffixMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid Async suffix.
        /// </summary>
        internal static string AvoidAsyncSuffixTitle {
            get {
                return ResourceManager.GetString("AvoidAsyncSuffixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Methods which return a Task should include the suffix &apos;Async&apos;.
        /// </summary>
        internal static string UseAsyncSuffixDescription {
            get {
                return ResourceManager.GetString("UseAsyncSuffixDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task-returning method &apos;{0}&apos; should end with &apos;Async&apos;.
        /// </summary>
        internal static string UseAsyncSuffixMessageFormat {
            get {
                return ResourceManager.GetString("UseAsyncSuffixMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use Async suffix.
        /// </summary>
        internal static string UseAsyncSuffixTitle {
            get {
                return ResourceManager.GetString("UseAsyncSuffixTitle", resourceCulture);
            }
        }
    }
}
