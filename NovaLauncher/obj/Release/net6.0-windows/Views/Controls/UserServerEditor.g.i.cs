﻿#pragma checksum "..\..\..\..\..\Views\Controls\UserServerEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3014DA00C26BFA030EBD00859783F712DAD2A113"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NovaLauncher.Views.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Wpf.Ui;
using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using Wpf.Ui.Controls.Navigation;
using Wpf.Ui.Converters;
using Wpf.Ui.Markup;
using Wpf.Ui.ValidationRules;


namespace NovaLauncher.Views.Controls {
    
    
    /// <summary>
    /// UserServerEditor
    /// </summary>
    public partial class UserServerEditor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Views\Controls\UserServerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.TextBox DetailsServerNameTxt;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\Controls\UserServerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DetailsPlaylistTxt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Views\Controls\UserServerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NumberBox DetailsMaxPlayersTxt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Views\Controls\UserServerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DetailsRegionTxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\Views\Controls\UserServerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AutoStartGameBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Views\Controls\UserServerEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.TextBox DetailsMatchmakingKeytxt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NovaLauncher;V1.0.0.0;component/views/controls/userservereditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Controls\UserServerEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DetailsServerNameTxt = ((Wpf.Ui.Controls.TextBox)(target));
            return;
            case 2:
            this.DetailsPlaylistTxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DetailsMaxPlayersTxt = ((Wpf.Ui.Controls.NumberBox)(target));
            return;
            case 4:
            this.DetailsRegionTxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.AutoStartGameBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.DetailsMatchmakingKeytxt = ((Wpf.Ui.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

