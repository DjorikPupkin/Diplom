﻿#pragma checksum "..\..\..\Pages\AplPageAllA.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3CA07499220C35C5B0EA31224A24C5F6D7033AB03142E42AEB928C690EC3F469"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ComService.Pages;
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


namespace ComService.Pages {
    
    
    /// <summary>
    /// AplPageAllA
    /// </summary>
    public partial class AplPageAllA : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\AplPageAllA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbSer;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\AplPageAllA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RedAplBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\AplPageAllA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\AplPageAllA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGApl;
        
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
            System.Uri resourceLocater = new System.Uri("/ComService;component/pages/aplpagealla.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AplPageAllA.xaml"
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
            this.CbSer = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\Pages\AplPageAllA.xaml"
            this.CbSer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbSer_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RedAplBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Pages\AplPageAllA.xaml"
            this.RedAplBtn.Click += new System.Windows.RoutedEventHandler(this.RedAplBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RemBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\AplPageAllA.xaml"
            this.RemBtn.Click += new System.Windows.RoutedEventHandler(this.RemBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DGApl = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

