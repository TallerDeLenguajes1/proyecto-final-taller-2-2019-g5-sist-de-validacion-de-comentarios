using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Administrador
    {
        int idAdministrador;
        string nombre;
        PaginaWeb pagina;


        private int idAdministrador1;
        private string nombre1;

        public Administrador(int idAdministrador, string nombre)
        {
            this.IdAdministrador = idAdministrador;
            this.Nombre = nombre;
        }

        public int IdAdministrador
        {
            get
            {
                return idAdministrador;
            }

            set
            {
                idAdministrador = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        internal PaginaWeb Pagina
        {
            get
            {
                return pagina;
            }

            set
            {
                pagina = value;
            }
        }

        public static void AgregarComentador(Comentador nuevoComentador)
        {

        }

        /// <summary>
        /// Método: EstadoDeComentarios: Indica si se muestran o no los comentarios realizados
        /// </summary>
        public static void EstadoDeComentarios(PaginaWeb pagina)
        {
            if (pagina.EstadoComentarios)
                pagina.EstadoComentarios = false;
            else
                pagina.EstadoComentarios = true;
        }

    }
}

