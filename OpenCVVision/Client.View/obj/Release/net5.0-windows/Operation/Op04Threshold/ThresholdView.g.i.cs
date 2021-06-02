﻿#pragma checksum "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EE635C8F6DB1815F00D49772FC54B9845847F6FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Client.ViewModel.Operation;
using LiveChartsCore.SkiaSharpView.WPF;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ReactiveUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using Wpf.Controls.PanAndZoom;


namespace Client.View.Operation {
    
    
    /// <summary>
    /// ThresholdView
    /// </summary>
    public partial class ThresholdView : ReactiveUI.ReactiveUserControl<Client.ViewModel.Operation.ThreshouldViewModel>, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card cardMain;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveChartsCore.SkiaSharpView.WPF.CartesianChart barChart;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxChannels;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxThreshouldType;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderThresh;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderMaxval;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Client.View;V1.0.0.0;component/operation/op04threshold/thresholdview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Operation\Op04Threshold\ThresholdView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cardMain = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            case 2:
            this.Title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.barChart = ((LiveChartsCore.SkiaSharpView.WPF.CartesianChart)(target));
            return;
            case 4:
            this.cbxChannels = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbxThreshouldType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.sliderThresh = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            this.sliderMaxval = ((System.Windows.Controls.Slider)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

