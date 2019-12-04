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
            if(comboEmpresa.SelectedItem.ToString() != "")
            {
                listaAux = conexionTraspasada.SelecionarComentarios(0, comboEmpresa.SelectedItem.ToString());

                for(int i=0; i < listaAux.Count(); i++)
                {
                    boxComentariosPendientes.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(1, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosAceptados.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(2, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosRechazados.Items.Add(listaAux[i]);
                }
            }
        }

        private void BotonAceptarComentario_Click(object sender, RoutedEventArgs e)
        {
            if(boxComentariosPendientes.SelectedItem != null)
            {
                botonAceptarComentarioRechazado.IsEnabled = false;

                botonRechazarComentarioAceptado.IsEnabled = false;

                botonAceptarComentario.IsEnabled = false;

                botonRechazarComentario.IsEnabled = false;

                conexionTraspasada.ModificarComentario(1, boxComentariosPendientes.SelectedItem.ToString());
            }

            if (comboEmpresa.SelectedItem.ToString() != "")
            {
                boxComentariosPendientes.Items.Remove(boxComentariosPendientes.SelectedItem);

                listaAux = conexionTraspasada.SelecionarComentarios(0, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosPendientes.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(1, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosAceptados.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(2, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosRechazados.Items.Add(listaAux[i]);
                }
            }
        }

        private void BotonRechazarComentario_Click(object sender, RoutedEventArgs e)
        {
            if(boxComentariosPendientes.SelectedItem != null)
            {
                conexionTraspasada.ModificarComentario(2, boxComentariosPendientes.SelectedItem.ToString());

                botonAceptarComentarioRechazado.IsEnabled = false;

                botonRechazarComentarioAceptado.IsEnabled = false;

                botonAceptarComentario.IsEnabled = false;

                botonRechazarComentario.IsEnabled = false;
            }

            if (comboEmpresa.SelectedItem.ToString() != "")
            {
                boxComentariosPendientes.Items.Remove(boxComentariosPendientes.SelectedItem);

                listaAux = conexionTraspasada.SelecionarComentarios(0, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosPendientes.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(1, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosAceptados.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(2, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosRechazados.Items.Add(listaAux[i]);
                }
            }
        }

        private void BotonAceptarComentarioRechazado_Click(object sender, RoutedEventArgs e)
        {
            if(boxComentariosRechazados.SelectedItem != null)
            {
                conexionTraspasada.ModificarComentario(1, boxComentariosRechazados.SelectedItem.ToString());

                boxComentariosRechazados.Items.Remove(boxComentariosRechazados.SelectedItem);

                botonRechazarComentarioAceptado.IsEnabled = false;

                botonAceptarComentarioRechazado.IsEnabled = false;

                botonAceptarComentario.IsEnabled = false;

                botonRechazarComentario.IsEnabled = false;
            }

            if (comboEmpresa.SelectedItem.ToString() != "")
            {
                boxComentariosRechazados.Items.Remove(boxComentariosRechazados.SelectedItem);

                listaAux = conexionTraspasada.SelecionarComentarios(0, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosPendientes.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(1, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosAceptados.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(2, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosRechazados.Items.Add(listaAux[i]);
                }
            }
        }

        private void BotonRechazarComentarioAceptado_Click(object sender, RoutedEventArgs e)
        {
            if(boxComentariosAceptados.SelectedItem != null)
            {
                conexionTraspasada.ModificarComentario(2, boxComentariosAceptados.SelectedItem.ToString());

                boxComentariosAceptados.Items.Remove(boxComentariosAceptados.SelectedItem);

                botonAceptarComentarioRechazado.IsEnabled = false;

                botonRechazarComentarioAceptado.IsEnabled = false;

                botonAceptarComentario.IsEnabled = false;

                botonRechazarComentario.IsEnabled = false;
            }

            if (comboEmpresa.SelectedItem.ToString() != "" )
            {
                listaAux = conexionTraspasada.SelecionarComentarios(0, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosPendientes.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(1, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosAceptados.Items.Add(listaAux[i]);
                }

                listaAux = conexionTraspasada.SelecionarComentarios(2, comboEmpresa.SelectedItem.ToString());

                for (int i = 0; i < listaAux.Count(); i++)
                {
                    boxComentariosRechazados.Items.Add(listaAux[i]);
                }
            }
        }

        private void BotonAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
