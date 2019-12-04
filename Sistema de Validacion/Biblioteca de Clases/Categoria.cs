using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Categoria
    {
        public static float CalcularPeso(int puntos, Comentario comentario)
        {
            return 0;
        }

    }
    public class Neutral : Categoria
    {
        public static int CalcularPeso(int puntos, Comentario comentario)
        {
            return puntos;
        }
    }

    public class Pesimista : Categoria
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

    public class Optimista : Categoria
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
