﻿#pragma checksum "..\..\JianceWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CEC6E92A47B209D6CE0CFDB0A8AD2110"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Microsoft.Research.DynamicDataDisplay.Charts.Shapes;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.Navigation;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using PsyHealth;
using PsyHealth.lib;
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
using Visifire.Charts;


namespace PsyHealth {
    
    
    /// <summary>
    /// JianceWindow
    /// </summary>
    public partial class JianceWindow : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas maincontent;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_hrv;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_maibo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_result;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_set;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas userconfig;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image radiomusic1;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image radiomusic2;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image radioxg1;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image radioxg2;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderVolume;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtmusicpath;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_checkfile;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_ok;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_cancle;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement media1;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid hrv_grid;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.ChartPlotter plotter;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.HorizontalDateTimeAxis dateAxis;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.Axes.VerticalIntegerAxis countAxis;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid maibo_grid;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid result_grid;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Userstate;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_zhushou;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas hxcon;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hximg;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement videoMediaElement;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_qiehuan;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_kaishi;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderspeed;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_tuichu;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Simon;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_xuexi;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_xunlian;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton btn_jilu;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\JianceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PsyHealth.lib.ImageButton Btn_backIndex;
        
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
            System.Uri resourceLocater = new System.Uri("/PsyHealth;component/jiancewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\JianceWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 11 "..\..\JianceWindow.xaml"
            ((PsyHealth.JianceWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.maincontent = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.btn_hrv = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 4:
            this.btn_maibo = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 5:
            this.btn_result = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 6:
            this.btn_set = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 7:
            this.userconfig = ((System.Windows.Controls.Canvas)(target));
            return;
            case 8:
            this.radiomusic1 = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.radiomusic2 = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.radioxg1 = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.radioxg2 = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            this.sliderVolume = ((System.Windows.Controls.Slider)(target));
            return;
            case 13:
            this.txtmusicpath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.btn_checkfile = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 15:
            this.btn_ok = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 16:
            this.btn_cancle = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 17:
            this.media1 = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 18:
            this.hrv_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 19:
            this.plotter = ((Microsoft.Research.DynamicDataDisplay.ChartPlotter)(target));
            return;
            case 20:
            this.dateAxis = ((Microsoft.Research.DynamicDataDisplay.Charts.HorizontalDateTimeAxis)(target));
            return;
            case 21:
            this.countAxis = ((Microsoft.Research.DynamicDataDisplay.Charts.Axes.VerticalIntegerAxis)(target));
            return;
            case 22:
            this.maibo_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 23:
            this.result_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 24:
            this.Userstate = ((System.Windows.Controls.Image)(target));
            return;
            case 25:
            this.btn_zhushou = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 26:
            this.hxcon = ((System.Windows.Controls.Canvas)(target));
            return;
            case 27:
            this.hximg = ((System.Windows.Controls.Image)(target));
            return;
            case 28:
            this.videoMediaElement = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 29:
            this.btn_qiehuan = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 30:
            this.btn_kaishi = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 31:
            this.sliderspeed = ((System.Windows.Controls.Slider)(target));
            return;
            case 32:
            this.btn_tuichu = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 33:
            this.Simon = ((System.Windows.Controls.Grid)(target));
            return;
            case 34:
            this.btn_xuexi = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 35:
            this.btn_xunlian = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 36:
            this.btn_jilu = ((PsyHealth.lib.ImageButton)(target));
            return;
            case 37:
            this.Btn_backIndex = ((PsyHealth.lib.ImageButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
