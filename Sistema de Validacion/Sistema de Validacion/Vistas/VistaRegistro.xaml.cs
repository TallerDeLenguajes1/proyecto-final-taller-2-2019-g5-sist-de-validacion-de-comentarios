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
using Biblioteca_de_Clases;

namespace Sistema_de_Validacion.Vistas
{
    /// <summary>
    /// Lógica de interacción para VistaRegistro.xaml
    /// </summary>
    public partial class VistaRegistro : Window
    {
        private Comentador ComentadorX;
        public VistaRegistro()
        {
            InitializeComponent();
        }

        private void BotonAceptar_Click(object sender, RoutedEventArgs e)
        {
            ComentadorX = new Comentador();

        }
    }
}
