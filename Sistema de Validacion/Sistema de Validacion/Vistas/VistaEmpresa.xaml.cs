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
    /// Lógica de interacción para VistaEmpresa.xaml
    /// </summary>
    public partial class VistaEmpresa : Window
    {
        Biblioteca_de_Clases.Conexion conexionTraspasada;

        public VistaEmpresa(Biblioteca_de_Clases.Conexion nuevaConexion)
        {
            InitializeComponent();

            conexionTraspasada = nuevaConexion;
        }

        private void BotonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if(boxNombre.Text != "" && boxRazon.Text != "" && boxRubro.Text != "")
            {
                conexionTraspasada.InsertarEmpresa(boxNombre.Text, boxRazon.Text, boxRubro.Text);
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }
    }
}
