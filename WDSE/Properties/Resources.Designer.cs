﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WDSE.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WDSE.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to var el = $(arguments[0]);
        ///var left = parseInt(el.offset().left);
        ///var top = parseInt(el.offset().top);
        ///var right = parseInt(left + el.outerWidth());
        ///var bottom = parseInt(top + el.outerHeight());
        ///const x = Math.max(left, 0);
        ///const y = Math.max(top, 0);
        ///var str = JSON.stringify({
        ///    x: x,
        ///    y: y,
        ///    width: right - x,
        ///    height: bottom - y
        ///});
        ///return str;.
        /// </summary>
        internal static string GetElementCoordinates {
            get {
                return ResourceManager.GetString("GetElementCoordinates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function IsElementVisible(ele) {
        ///
        ///    const win = $(window);
        ///
        ///    const viewport = {
        ///        top: win.scrollTop(),
        ///        left: win.scrollLeft()
        ///    };
        ///    viewport.right = viewport.left + win.width();
        ///    viewport.bottom = viewport.top + win.height();
        ///
        ///    const bounds = ele.offset();
        ///    bounds.right = bounds.left + ele.outerWidth();
        ///    bounds.bottom = bounds.top + ele.outerHeight();
        ///
        ///    return (!(viewport.right &lt; bounds.left || viewport.left &gt; bounds.right || viewport.bottom &lt; bounds.to [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetElementVisibleState {
            get {
                return ResourceManager.GetString("GetElementVisibleState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var ele = document.createElement(&quot;script&quot;);
        ///ele.src = &quot;https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js&quot;;
        ///var body = document.getElementsByTagName(&quot;head&quot;)[0];
        ///body.appendChild(ele);.
        /// </summary>
        internal static string SetJQuery {
            get {
                return ResourceManager.GetString("SetJQuery", resourceCulture);
            }
        }
    }
}