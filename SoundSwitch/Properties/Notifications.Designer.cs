﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoundSwitch.Properties {
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
    internal class Notifications {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Notifications() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SoundSwitch.Properties.Notifications", typeof(Notifications).Assembly);
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
        ///   Looks up a localized string similar to The audio file you selected to be use as notification can&apos;t be found. {0} switched the notification setting back to {1}..
        /// </summary>
        internal static string AudioFileNotFound {
            get {
                return ResourceManager.GetString("AudioFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Audio file not found.
        /// </summary>
        internal static string AudioFileNotFoundTitle {
            get {
                return ResourceManager.GetString("AudioFileNotFoundTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Window&apos;s Notification: Use the usual OS notification system
        ///Sound Notification: Play a sound on the switched audio device
        ///No Notification: ... No Notification at all..
        /// </summary>
        internal static string explanation {
            get {
                return ResourceManager.GetString("explanation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Customized Sound Notification.
        /// </summary>
        internal static string NotifCustom {
            get {
                return ResourceManager.GetString("NotifCustom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Notification.
        /// </summary>
        internal static string NotifNone {
            get {
                return ResourceManager.GetString("NotifNone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sound Notification.
        /// </summary>
        internal static string NotifSound {
            get {
                return ResourceManager.GetString("NotifSound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows&apos;s Notification.
        /// </summary>
        internal static string NotifWindows {
            get {
                return ResourceManager.GetString("NotifWindows", resourceCulture);
            }
        }
    }
}
