using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador
    {
        int idAdministrador;
        string nombre;

       

        public int IdAdministrador { get => idAdministrador; set => idAdministrador = value; }
        public string Nombre { get => nombre; set => nombre = value; }

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
