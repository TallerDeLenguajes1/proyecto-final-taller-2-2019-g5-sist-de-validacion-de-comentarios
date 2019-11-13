using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaDeClases
{
    class Administrador
    {
        int idAdministrador;
        string nombre;
        PaginaWeb pagina;


        private int idAdministrador1;
        private string nombre1;

        public int IdAdministrador { get => idAdministrador1; set => idAdministrador1 = value; }
        public string Nombre { get => nombre1; set => nombre1 = value; }
        internal PaginaWeb Pagina { get => pagina; set => pagina = value; }

        public Administrador(int idAdministrador, string nombre)
        {
            this.idAdministrador = idAdministrador;
            this.nombre = nombre;
        }

        public static void AgregarComentador(Comentador nuevoComentador)
        {
            
        }

        public static void EstadoDeComentarios()
        {

        }

    }
}
