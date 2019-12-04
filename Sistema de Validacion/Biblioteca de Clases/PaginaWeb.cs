using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    class PaginaWeb
    {
        private bool estadoComentarios;

        List<Comentario> listaDeComentarios;

        List<Comentador> listaDeComentadores;

        Empresa empresaPropietaria;

        public bool EstadoComentarios// activa o desactiva comentarios de la pagina web
        {
            get
            {
                return estadoComentarios;
            }

            set
            {
                estadoComentarios = value;
            }
        }

        public List<Comentario> ListaDeComentarios
        {
            get
            {
                return listaDeComentarios;
            }

            set
            {
                listaDeComentarios = value;
            }
        }

        public List<Comentador> ListaDeComentadores
        {
            get
            {
                return listaDeComentadores;
            }

            set
            {
                listaDeComentadores = value;
            }
        }

        internal Empresa EmpresaPropietaria
        {
            get
            {
                return empresaPropietaria;
            }

            set
            {
                empresaPropietaria = value;
            }
        }

        public void OfrecerRedesSociales()//si un comentario es positivo, muestra el listado de redes sociales de la empresa
        {
            var redesSociales = EmpresaPropietaria.RedesSociales;


        }

        private void nuevoComentario(Comentario nuevoComentario)// agrega el nuevo comentario a la lista de comentarios de la pagina
        {

            listaDeComentarios.Add(nuevoComentario);

        }
        private void validarComentario(Comentario comentarioAValidar)// se encarga de determinar si el comentario es valido o no
        {
            if (listaDeComentadores.Contains(comentarioAValidar.ComentadorDuenio))//aqui verifica que el usuario que comento sea un comentador valido
            {
                comentarioAValidar.EsValido = true;
            }
            else
            {
                comentarioAValidar.EsValido = false;
            }
            //basicamente se en carga de darle estado de validez a los comentarios
        }



    }
}

