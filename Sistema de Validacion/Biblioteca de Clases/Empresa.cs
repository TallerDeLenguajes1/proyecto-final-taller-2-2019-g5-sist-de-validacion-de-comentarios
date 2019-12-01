using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    class Empresa
    {
        private string nombre;
        private string rubro;
        private string razonSocial;
        private List<string> redesSociales;
        Administrador admin;

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

        public string Rubro
        {
            get
            {
                return rubro;
            }

            set
            {
                rubro = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }

            set
            {
                razonSocial = value;
            }
        }

        public List<string> RedesSociales
        {
            get
            {
                return redesSociales;
            }

            set
            {
                redesSociales = value;
            }
        }

        public Administrador Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }

        private void PorcentajeComentarios(DateTime inicio, DateTime fin)//
        {
            int contPos = 0, contNeg = 0, contTot = 0, intFechaMayor, intFechaMenor;
            List<Comentario> it = this.admin.Pagina.ListaDeComentarios;
            DateTime ahora = DateTime.Now;
            DateTime FechaComentario;
            foreach (var T in it)
            {
                FechaComentario = it.First().FechaRealizado;
                intFechaMenor = (DateTime.Compare(FechaComentario, inicio));
                intFechaMayor = (DateTime.Compare(FechaComentario, fin));
                if (intFechaMenor >= 0 && intFechaMayor < 0)
                {
                    contTot++;
                    if (it.First().CalificarComentario().Equals("positivo"))
                    {
                        contPos++;
                    }
                    else
                        contNeg++;
                }
            }
            Console.WriteLine("el porcentaje de positivos es:", (contPos * 100) / contNeg);
        }

    }
}
}
