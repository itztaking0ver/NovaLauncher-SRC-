﻿#pragma checksum "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916A8AF757074F000FF35A4835C018097947C54F"
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


namespace NovaLauncher.Views.Controls.Settings {
    
    
    /// <summary>
    /// MemoryLeakFixOption
    /// </summary>
    public partial class MemoryLeakFixOption : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.CardAction SettingCard;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.ToggleSwitch MLFSwitch;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MLFText;
        
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
            System.Uri resourceLocater = new System.Uri("/NovaLauncher;component/views/controls/settings/memoryleakfixoption.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml"
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
            this.SettingCard = ((Wpf.Ui.Controls.CardAction)(target));
            
            #line 10 "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml"
            this.SettingCard.Loaded += new System.Windows.RoutedEventHandler(this.LoadContent);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml"
            this.SettingCard.Click += new System.Windows.RoutedEventHandler(this.SettingCard_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MLFSwitch = ((Wpf.Ui.Controls.ToggleSwitch)(target));
            
            #line 23 "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml"
            this.MLFSwitch.Checked += new System.Windows.RoutedEventHandler(this.EnableMLF);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\..\..\Views\Controls\Settings\MemoryLeakFixOption.xaml"
            this.MLFSwitch.Unchecked += new System.Windows.RoutedEventHandler(this.MLFSwitch_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MLFText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

