using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    class Categoria
    {
        public static float CalcularPeso(int puntos, Comentario comentario)
        {
            return 0;
        }

    }
    class Neutral : Categoria
    {
        public static int CalcularPeso(int puntos, Comentario comentario)
        {
            return puntos;
        }
    }

    class Pesimista : Categoria
    {
        public static int CalcularPeso(int puntos, Comentario comentario)
        {
            int peso;

            if (comentario.CalificarComentario() == "Negativo")
            {
                peso = puntos / 2;
            }
            else
                peso = puntos * 2;
            return peso;
        }
    }

    class Optimista : Categoria
    {
        public static int CalcularPeso(int puntos, Comentario comentario)
        {
            int peso;
            if (comentario.CalificarComentario() == "Positivo")
            {
                peso = puntos / 2;
            }
            else
                peso = puntos * 2;
            return peso;
        }

    }
}
