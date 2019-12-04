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
    /// Lógica de interacción para VistaComentario.xaml
    /// </summary>
    public partial class VistaComentario : Window
    {
        string sql;

        string duenio;

        string[] listaAux;

        Biblioteca_de_Clases.Conexion conexionTraspasada;

        public VistaComentario(Biblioteca_de_Clases.Conexion nuevaConexion, string usuarioDuenio)
        {
            InitializeComponent();

            duenio = usuarioDuenio;

            conexionTraspasada = nuevaConexion;

            sql = "tempresas";

            listaAux = conexionTraspasada.ConsultaGeneral(sql);

            for(int i = 0; i < listaAux.Count(); i++)
            {
                comboEmpresas.Items.Add(listaAux[i]);
            }
        }

        private void BotonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if(comboEmpresas.Text != "" && boxComentario.Text != "")
            {
                conexionTraspasada.InsertarComentario(boxComentario.Text, comboEmpresas.Text, duenio);
            }
        }
    }
}
