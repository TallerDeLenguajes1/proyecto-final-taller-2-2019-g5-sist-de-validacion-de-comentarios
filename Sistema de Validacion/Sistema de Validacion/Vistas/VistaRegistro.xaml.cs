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
    /// Lógica de interacción para VistaRegistro.xaml
    /// </summary>
    public partial class VistaRegistro : Window
    {
        string sql;

        string[] listaAux;

        Biblioteca_de_Clases.Conexion conexionTraspasada;
        public VistaRegistro(Biblioteca_de_Clases.Conexion nuevaConexion)
        {
            InitializeComponent();

            conexionTraspasada = nuevaConexion;

            sql = "Pais";

            listaAux = conexionTraspasada.ConsultaGeneral(sql);

            for (int i = 0; i < listaAux.Count(); i++)
            {
                comboPais.Items.Add(listaAux[i]);
            }

        }

        private void BotonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if(boxUsuario.Text != "" && boxContraseña.Password != "" && comboPais.Text != "" && comboProvincia.Text != "" && comboCiudad.Text != "")
            {
                conexionTraspasada.insertar(boxUsuario.Text, boxContraseña.Password, comboCiudad.Text);

                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void ComboPais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboProvincia.IsEnabled = true;

            sql = "Provincia";

            listaAux = conexionTraspasada.ConsultaGeneral(sql);

            for (int i = 0; i < listaAux.Count(); i++)
            {
                comboProvincia.Items.Add(listaAux[i]);
            }
        }

        private void ComboProvincia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboCiudad.IsEnabled = true;

            sql = "Ciudad";

            listaAux = conexionTraspasada.ConsultaGeneral(sql);

            for (int i = 0; i < listaAux.Count(); i++)
            {
                comboCiudad.Items.Add(listaAux[i]);
            }
        }
    }
}
