﻿#pragma checksum "..\..\Plant Section.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2870636296E4B20F8CE3B719590F9D10D54DCD6543DFA6EC13CE29725DB1C80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NurseryManagementSystem;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace NurseryManagementSystem {
    
    
    /// <summary>
    /// Plant_Section
    /// </summary>
    public partial class Plant_Section : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Plant Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Plant Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updatebtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Plant Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deletebtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Plant Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchbtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Plant Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitbtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Plant Section.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitbtn_Copy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NurseryManagementSystem;component/plant%20section.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Plant Section.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Plant Section.xaml"
            this.addbtn.Click += new System.Windows.RoutedEventHandler(this.addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.updatebtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Plant Section.xaml"
            this.updatebtn.Click += new System.Windows.RoutedEventHandler(this.updatebtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deletebtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Plant Section.xaml"
            this.deletebtn.Click += new System.Windows.RoutedEventHandler(this.deletebtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchbtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Plant Section.xaml"
            this.searchbtn.Click += new System.Windows.RoutedEventHandler(this.searchbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.exitbtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Plant Section.xaml"
            this.exitbtn.Click += new System.Windows.RoutedEventHandler(this.exitbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.exitbtn_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Plant Section.xaml"
            this.exitbtn_Copy.Click += new System.Windows.RoutedEventHandler(this.exitbtn2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

