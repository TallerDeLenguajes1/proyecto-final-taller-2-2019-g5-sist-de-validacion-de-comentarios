#pragma checksum "..\..\..\Vistas\VistaVerComentarios.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25F00A46CDCA4BC0DFCA496FD96269B27C82432F59DD7DB9F930C37E3989C7BB"
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


namespace Sistema_de_Validacion.Vistas
{


    /// <summary>
    /// VistaVerComentarios
    /// </summary>
    public partial class VistaVerComentarios : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\..\Vistas\VistaVerComentarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botonAceptar;

#line default
#line hidden


#line 11 "..\..\..\Vistas\VistaVerComentarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboEmpresa;

#line default
#line hidden


#line 19 "..\..\..\Vistas\VistaVerComentarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botonAceptarComentario;

#line default
#line hidden


#line 20 "..\..\..\Vistas\VistaVerComentarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botonRechazarComentario;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Sistema de Validacion;component/vistas/vistavercomentarios.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Vistas\VistaVerComentarios.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.botonAceptar = ((System.Windows.Controls.Button)(target));
                    return;
                case 2:
                    this.comboEmpresa = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 3:
                    this.botonAceptarComentario = ((System.Windows.Controls.Button)(target));
                    return;
                case 4:
                    this.botonRechazarComentario = ((System.Windows.Controls.Button)(target));
                    return;
                case 5:
                    this.botonAceptarComentario_Copy = ((System.Windows.Controls.Button)(target));
                    return;
                case 6:
                    this.botonRechazarComentario_Copy = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button botonAceptarComentarioRechazado;
        internal System.Windows.Controls.Button botonRechazarComentarioAceptado;
    }
}

