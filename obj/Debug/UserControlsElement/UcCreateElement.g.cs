﻿#pragma checksum "..\..\..\UserControlsElement\UcCreateElement.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "880D6253C995CBF2205007CD9ACC2B78DCB938CAE739037B7C08A47E002724BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NCKH.UserControlsElement;
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


namespace NCKH.UserControlsElement {
    
    
    /// <summary>
    /// UcCreateElement
    /// </summary>
    public partial class UcCreateElement : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\UserControlsElement\UcCreateElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NCKH.UserControlsElement.UcCreateElement uscCreateEle;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\UserControlsElement\UcCreateElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cb_Section;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\UserControlsElement\UcCreateElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Name;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\UserControlsElement\UcCreateElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_First_Node;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\UserControlsElement\UcCreateElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Last_Node;
        
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
            System.Uri resourceLocater = new System.Uri("/NCKH;component/usercontrolselement/uccreateelement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlsElement\UcCreateElement.xaml"
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
            this.uscCreateEle = ((NCKH.UserControlsElement.UcCreateElement)(target));
            return;
            case 2:
            this.Cb_Section = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txb_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txb_First_Node = ((System.Windows.Controls.TextBox)(target));
            
            #line 142 "..\..\..\UserControlsElement\UcCreateElement.xaml"
            this.txb_First_Node.GotFocus += new System.Windows.RoutedEventHandler(this.txb_First_Node_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txb_Last_Node = ((System.Windows.Controls.TextBox)(target));
            
            #line 168 "..\..\..\UserControlsElement\UcCreateElement.xaml"
            this.txb_Last_Node.GotFocus += new System.Windows.RoutedEventHandler(this.txb_Last_Node_GotFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

