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
    /// Lógica de interacción para VistaLogueo.xaml
    /// </summary>
    public partial class VistaLogueo : Window
    {
        Biblioteca_de_Clases.Conexion conexionTraspasada;

        public VistaLogueo(Biblioteca_de_Clases.Conexion nuevaConexion)
        {
            InitializeComponent();

            conexionTraspasada = nuevaConexion;
        }

        private void botonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void botonIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
           
            if(boxUsuario.Text == "admin" && boxContrasenia.Password == "admin")
            {
                VistaAdministrador nuevaVistaAdministrador = new VistaAdministrador(conexionTraspasada);

                nuevaVistaAdministrador.ShowDialog();
            }
            else
            {
                int respuesta = conexionTraspasada.Logeo(boxUsuario.Text, boxContrasenia.Password);

                if (respuesta == 1)
                {
                    VistaComentario nuevaVistaComentario = new VistaComentario(conexionTraspasada, boxUsuario.Text);

                    nuevaVistaComentario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                }
            }
        }
    }
}
