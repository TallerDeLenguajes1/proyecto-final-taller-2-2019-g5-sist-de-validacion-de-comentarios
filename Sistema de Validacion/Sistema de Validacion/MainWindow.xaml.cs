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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Biblioteca_de_Clases;

namespace Sistema_de_Validacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        Conexion nuevaConexion = new Conexion();

        private void BotonLogeo_Click(object sender, RoutedEventArgs e)
        {
            Vistas.VistaLogueo nuevaVistaLogeo = new Vistas.VistaLogueo(nuevaConexion);

            nuevaVistaLogeo.ShowDialog();
        }

        private void BotonRegistro_Click(object sender, RoutedEventArgs e)
        {
            Vistas.VistaRegistro nuevaVistaRegistro = new Vistas.VistaRegistro(nuevaConexion);

            nuevaVistaRegistro.ShowDialog();
        }
    }
}
