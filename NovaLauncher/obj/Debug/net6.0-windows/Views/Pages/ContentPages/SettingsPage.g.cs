﻿#pragma checksum "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74515CA541AE09E330CB62266CD711F046516170"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NovaLauncher.Views.Pages;
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


namespace NovaLauncher.Views.Pages.ContentPages {
    
    
    /// <summary>
    /// SettingsPage
    /// </summary>
    public partial class SettingsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush BorderBackground;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.InfoBar NoteInfo;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackSettings;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logoutbtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Uninstallbtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.ProgressRing LoadingRing;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FTDStxt;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button Retrybtn;
        
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
            System.Uri resourceLocater = new System.Uri("/NovaLauncher;component/views/pages/contentpages/settingspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
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
            this.BorderBackground = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 2:
            this.NoteInfo = ((Wpf.Ui.Controls.InfoBar)(target));
            return;
            case 3:
            this.StackSettings = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.Logoutbtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
            this.Logoutbtn.Click += new System.Windows.RoutedEventHandler(this.Logoutbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Uninstallbtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
            this.Uninstallbtn.Click += new System.Windows.RoutedEventHandler(this.UninstallLauncher);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LoadingRing = ((Wpf.Ui.Controls.ProgressRing)(target));
            return;
            case 7:
            this.FTDStxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Retrybtn = ((Wpf.Ui.Controls.Button)(target));
            
            #line 47 "..\..\..\..\..\..\Views\Pages\ContentPages\SettingsPage.xaml"
            this.Retrybtn.Click += new System.Windows.RoutedEventHandler(this.Retrybtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

