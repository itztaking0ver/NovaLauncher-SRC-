﻿#pragma checksum "..\..\..\..\..\Views\Controls\NewBuild.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BBE782A3EF7B9996E0E3680CAD1753D96CE937C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// NewBuild
    /// </summary>
    public partial class NewBuild : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Flyout FLYOUT;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button libraryButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock seasonName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock chapterText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statusText;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SeasonSettingsbtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush SeasonBrush;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NovaLauncher;V1.0.0.0;component/views/controls/newbuild.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FLYOUT = ((Wpf.Ui.Controls.Flyout)(target));
            return;
            case 2:
            this.libraryButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\Views\Controls\NewBuild.xaml"
            this.libraryButton.Click += new System.Windows.RoutedEventHandler(this.SendButtonRequest);
            
            #line default
            #line hidden
            return;
            case 3:
            this.seasonName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.chapterText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.statusText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.SeasonSettingsbtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.SeasonBrush = ((System.Windows.Media.ImageBrush)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

