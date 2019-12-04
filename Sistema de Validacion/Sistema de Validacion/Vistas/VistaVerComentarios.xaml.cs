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
    /// Lógica de interacción para VistaVerComentarios.xaml
    /// </summary>
    public partial class VistaVerComentarios : Window
    {

        Biblioteca_de_Clases.Conexion conexionTraspasada;

        string sql;

        string[] listaAux;

        public VistaVerComentarios(Biblioteca_de_Clases.Conexion nuevaConexion)
        {
            InitializeComponent();

            conexionTraspasada = nuevaConexion;

            sql = "tempresas";

            listaAux = conexionTraspasada.ConsultaGeneral(sql);

            for(int i= 0; i < listaAux.Count(); i++)
            {
                comboEmpresa.Items.Add(listaAux[i]);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            botonAceptarComentario.IsEnabled = IsEnabled;

            botonRechazarComentario.IsEnabled = IsEnabled;
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            botonAceptarComentarioRechazado.IsEnabled = IsEnabled;
        }

        private void ListBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            botonRechazarComentarioAceptado.IsEnabled = IsEnabled;
        }

        private void ComboEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
