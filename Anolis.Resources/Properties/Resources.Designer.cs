﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3615
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anolis.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Anolis.Resources.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The GNU General Public License (GPL)
        ///Version 2, June 1991
        ///
        ///Copyright (C) 1989, 1991 Free Software Foundation, Inc.
        ///59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
        ///
        ///Everyone is permitted to copy and distribute verbatim copies
        ///of this license document, but changing it is not allowed.
        ///
        ///Preamble
        ///
        ///The licenses for most software are designed to take away your freedom to share and change it. By contrast, the GNU General Public License is intended to guarantee your freedom to share and change free  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string LegalGpl {
            get {
                return ResourceManager.GetString("LegalGpl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to =======================================
        ///         Licensing Overview
        ///=======================================
        ///
        ///Anolis.Core and Anolis.Resourcer licensed under the GNU GPL v2 license.
        ///
        ///Code Copyright 2008-2009 David Rees
        ///
        ///Anolis.Core makes use of LZMA Compression, which is placed in the Public Domain
        ///The source for the LZMA Compression is available from http://www.7-zip.org
        ///
        ///Anolis.Installer makes use of contributions from Sven Groot under the BSD license.
        ///The source for his Vista dialogs toolkit i [rest of string was truncated]&quot;;.
        /// </summary>
        public static string LegalOverview {
            get {
                return ResourceManager.GetString("LegalOverview", resourceCulture);
            }
        }
        
        public static byte[] Win32EmptyPE {
            get {
                object obj = ResourceManager.GetObject("Win32EmptyPE", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
