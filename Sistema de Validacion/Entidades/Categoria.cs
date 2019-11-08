using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public static float CalcularPeso(int puntos) { }
    }

    public class Neutral : Categoria
    {
        public static int CalcularPeso(int puntos)
        {

        }
    }

    public class Pesimista: Categoria
    {
        public static int CalcularPeso(int puntos)
        {
            int peso;

            if(CalificarComentario() == "Negativo")
            {
                peso = puntos / 2;
            }
            return peso;
        }
    }

    public class Optimista : Categoria
    {
        public static int CalcularPeso(int puntos)
        {

        }
    }
}
