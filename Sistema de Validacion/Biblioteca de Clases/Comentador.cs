using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Comentador
    {
        string ciudad;

        string provincia;

        string pais;

        int cantidadPositivos;

        int cantidadNegativos;

        List<Comentario> ListaDeComentarios;

        Categoria tipoComentador;

        public void CambiarPositivismo(Comentario nuevoComentario) // AGREGA UN COMENTARIO POSITIVO O NEGATIVO EN FUNCION A LOS PUNTOS DE ESTE
        {
            if (nuevoComentario.CalificarComentario() == "positivo")
            {
                cantidadPositivos++;
            }

            else
            {
                cantidadNegativos++;
            }
        }

        /*public int CalcularPeso(int puntos) //CALCULA EL PESO DE UN COMENTARIO EN BASE A LOS PUNTOS DEL MISMO Y EL TIPO DE COMENTADOR QUE ES
        {
            int pesoCalculado = tipoComentador.CalcularPeso(puntos);

            return pesoCalculado;
        }*/

        public void CambiarTipo() //CAMBIA EL TIPO DE COMENTADOR DEPENDIENDO DE LA CANTIDAD DE COMENTARIOS POSITIVOS O NEGATIVOS QUE TENGA
        {
            if (ListaDeComentarios.Count() * 0.6 <= cantidadPositivos)
            {
                tipoComentador = new Optimista();
            }
            else
            {
                if (ListaDeComentarios.Count() * 0.6 <= cantidadNegativos)
                {
                    tipoComentador = new Pesimista();
                }

                else
                {
                    tipoComentador = new Neutral();
                }
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }

        public int CantidadPositivos
        {
            get
            {
                return cantidadPositivos;
            }

            set
            {
                cantidadPositivos = value;
            }
        }

        public int CantidadNegativos
        {
            get
            {
                return cantidadNegativos;
            }

            set
            {
                cantidadNegativos = value;
            }
        }

        public List<Comentario> ListaDeComentarios1
        {
            get
            {
                return ListaDeComentarios;
            }

            set
            {
                ListaDeComentarios = value;
            }
        }

        public Categoria TipoComentador
        {
            get
            {
                return tipoComentador;
            }

            set
            {
                tipoComentador = value;
            }
        }

        
    }
}
