﻿#pragma checksum "..\..\..\UserControlsElement\UcCreateNode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE6AAA0539C613B277B3ABB5E189C7B90B32C5BB8E001C3FA0A6517DA76F0942"
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
    /// UcCreateNode
    /// </summary>
    public partial class UcCreateNode : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\UserControlsElement\UcCreateNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NCKH.UserControlsElement.UcCreateNode UscCreateNode;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\UserControlsElement\UcCreateNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Node;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\UserControlsElement\UcCreateNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Chk_Click_Create_Node;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UserControlsElement\UcCreateNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Coordinates;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\UserControlsElement\UcCreateNode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Apply;
        
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
            System.Uri resourceLocater = new System.Uri("/NCKH;component/usercontrolselement/uccreatenode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlsElement\UcCreateNode.xaml"
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
            this.UscCreateNode = ((NCKH.UserControlsElement.UcCreateNode)(target));
            return;
            case 2:
            this.Grid_Node = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Chk_Click_Create_Node = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\UserControlsElement\UcCreateNode.xaml"
            this.Chk_Click_Create_Node.Click += new System.Windows.RoutedEventHandler(this.Chk_Click_Create_Node_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txb_Coordinates = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_Apply = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
