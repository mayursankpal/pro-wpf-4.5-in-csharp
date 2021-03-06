﻿#pragma checksum "..\..\CodePlayback.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7C892E711A92E28E9B1D041462A58DA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SoundAndVideo;
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


namespace SoundAndVideo {
    
    
    /// <summary>
    /// CodePlayback
    /// </summary>
    public partial class CodePlayback : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\CodePlayback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement media;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CodePlayback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderPosition;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\CodePlayback.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblTime;
        
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
            System.Uri resourceLocater = new System.Uri("/SoundAndVideo;component/codeplayback.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CodePlayback.xaml"
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
            this.media = ((System.Windows.Controls.MediaElement)(target));
            
            #line 19 "..\..\CodePlayback.xaml"
            this.media.MediaOpened += new System.Windows.RoutedEventHandler(this.media_MediaOpened);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\CodePlayback.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdPlay_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 22 "..\..\CodePlayback.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdStop_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\CodePlayback.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cmdPause_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.sliderPosition = ((System.Windows.Controls.Slider)(target));
            
            #line 54 "..\..\CodePlayback.xaml"
            this.sliderPosition.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderPosition_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

