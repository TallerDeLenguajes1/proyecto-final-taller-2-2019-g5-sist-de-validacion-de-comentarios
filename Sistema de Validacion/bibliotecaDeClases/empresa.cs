﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaDeClases
{
    class empresa
    {
       private string nombre;
       private string rubro;
       private string razonSocial;
       private List<string> redesSociales;
       administrador admin;

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

        public administrador Admin
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

        }
        
    }
}
