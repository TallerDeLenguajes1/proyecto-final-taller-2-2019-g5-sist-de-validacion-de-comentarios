using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sistema_de_Validacion.Vistas
{
    /// <summary>
    /// Lógica de interacción para VistaAdministrador.xaml
    /// </summary>
    public partial class VistaAdministrador : Window
    {
        Biblioteca_de_Clases.Conexion conexionTraspasada;

        public VistaAdministrador(Biblioteca_de_Clases.Conexion nuevaConexion)
        {
            InitializeComponent();

            conexionTraspasada = nuevaConexion;
        }

        private void botonAgregarEmpresa_Click(object sender, RoutedEventArgs e)
        {
            VistaEmpresa nuevaVistaEmpresa = new VistaEmpresa(conexionTraspasada);

            nuevaVistaEmpresa.ShowDialog();
        }

        private void BotonDesconectar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BotonVerComentarios_Click(object sender, RoutedEventArgs e)
        {
            VistaVerComentarios nuevavistaVerComentarios = new VistaVerComentarios(conexionTraspasada);

            nuevavistaVerComentarios.ShowDialog();
        }
    }
}
