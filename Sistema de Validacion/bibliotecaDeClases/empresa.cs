using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaDeClases
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
            PaginaWeb lista;
        }
        
    }
}
