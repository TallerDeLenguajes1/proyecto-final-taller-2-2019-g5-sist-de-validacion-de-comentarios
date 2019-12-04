using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Comentario
    {
        string contenido;

        int puntuacion;

        DateTime fechaRealizado;

        bool esValido;

        Comentador comentadorDuenio; //DUEÑO DEL COMENTARIO

        /*public int ObtenerPeso() //OBTIENE EL PESO DEL COMENTARIO
        {
            int pesoComentario = comentadorDuenio.CalcularPeso(Puntuacion);

            return pesoComentario;
        }*/

        public string CalificarComentario() //CALIFICA UN COMENTARIO EN FUNCION A SU VALOR
        {
            string calificacion;

            if (puntuacion > 5)
            {
                calificacion = "positivo";
            }
            else
            {
                calificacion = "negativo";
            }

            return calificacion;
        }

        public string Contenido
        {
            get
            {
                return contenido;
            }

            set
            {
                contenido = value;
            }
        }

        public int Puntuacion
        {
            get
            {
                return puntuacion;
            }

            set
            {
                puntuacion = value;
            }
        }

        public DateTime FechaRealizado
        {
            get
            {
                return fechaRealizado;
            }

            set
            {
                fechaRealizado = value;
            }
        }

        public bool EsValido
        {
            get
            {
                return esValido;
            }

            set
            {
                esValido = value;
            }
        }

        internal Comentador ComentadorDuenio
        {
            get
            {
                return comentadorDuenio;
            }

            set
            {
                comentadorDuenio = value;
            }
        }
    }
}
