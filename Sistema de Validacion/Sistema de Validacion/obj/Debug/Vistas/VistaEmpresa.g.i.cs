﻿#pragma checksum "..\..\..\Vistas\VistaEmpresa.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0FB2E5B69FDF9B9678C5DDCB20E4D4B120C31314D0BA30DB9078D9605BEFB4BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Sistema_de_Validacion.Vistas;
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


namespace Sistema_de_Validacion.Vistas {
    
    
    /// <summary>
    /// VistaEmpresa
    /// </summary>
    public partial class VistaEmpresa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Vistas\VistaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxNombre;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Vistas\VistaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxRazon;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Vistas\VistaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxRubro;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Vistas\VistaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botonAceptar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Vistas\VistaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botonCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/Sistema de Validacion;component/vistas/vistaempresa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\VistaEmpresa.xaml"
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
            this.boxNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.boxRazon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.boxRubro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.botonAceptar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Vistas\VistaEmpresa.xaml"
            this.botonAceptar.Click += new System.Windows.RoutedEventHandler(this.BotonAceptar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.botonCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Vistas\VistaEmpresa.xaml"
            this.botonCancelar.Click += new System.Windows.RoutedEventHandler(this.BotonCancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

