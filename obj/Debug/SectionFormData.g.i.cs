﻿#pragma checksum "..\..\SectionFormData.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C511F20EF784954D8527A54BD2FCE11897599AA940E54DE576353E6FDB3AADA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NCKH;
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


namespace NCKH {
    
    
    /// <summary>
    /// SectionFormData
    /// </summary>
    public partial class SectionFormData : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\SectionFormData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NCKH.SectionFormData Section_Form;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\SectionFormData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Section;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\SectionFormData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_ID;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\SectionFormData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Name_Section;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\SectionFormData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cb_Concreate;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\SectionFormData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cb_Section_Shape;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\SectionFormData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridShapeType;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\SectionFormData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Import;
        
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
            System.Uri resourceLocater = new System.Uri("/NCKH;component/sectionformdata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SectionFormData.xaml"
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
            this.Section_Form = ((NCKH.SectionFormData)(target));
            return;
            case 2:
            this.Grid_Section = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txb_ID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txb_Name_Section = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Cb_Concreate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Cb_Section_Shape = ((System.Windows.Controls.ComboBox)(target));
            
            #line 106 "..\..\SectionFormData.xaml"
            this.Cb_Section_Shape.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cb_Section_Shape_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GridShapeType = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.btn_Import = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\SectionFormData.xaml"
            this.btn_Import.Click += new System.Windows.RoutedEventHandler(this.btn_Import_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

