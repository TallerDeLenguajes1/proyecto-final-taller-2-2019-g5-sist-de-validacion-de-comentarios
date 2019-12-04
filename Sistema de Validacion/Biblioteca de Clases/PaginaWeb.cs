using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class PaginaWeb
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

        /// <summary>
        /// Ofrecer Redes Sociales: método que muestra el listado de redes sociales de una determinada
        /// empresa si el comentario realizado es positivo.
        /// </summary>
        public void OfrecerRedesSociales()
        {
            var redesSociales = empresaPropietaria.RedesSociales;


        }

        private void nuevoComentario(Comentario nuevoComentario)// agrega el nuevo comentario a la lista de comentarios de la pagina
        {

            listaDeComentarios.Add(nuevoComentario);

        }

        /// <summary>
        /// Validar Comentario: determina si un comentario es válido o no, verificando que el usuario
        /// sea un comentador registrado.
        /// </summary>
        private void validarComentario(Comentario comentarioAValidar)
        {
            if (listaDeComentadores.Contains(comentarioAValidar.comentarioDuenio))//aqui verifica que el usuario que comento sea un comentador valido
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
