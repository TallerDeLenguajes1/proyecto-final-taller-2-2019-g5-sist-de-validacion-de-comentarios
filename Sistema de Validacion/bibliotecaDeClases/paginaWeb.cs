﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaDeClases
{
    class paginaWeb
    {
        private bool estadoComentarios;

        List<Comentario> listaDeComentarios;

        List<Comentador> listaDeComentadores;

        empresa empresaPropietaria;

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

        public void OfrecerRedesSociales()//si un comentario es positivo, muestra el listado de redes sociales de la empresa
        {
            var redesSociales = empresaPropietaria.RedesSociales;

            
        }
        
        private void nuevoComentario(Comentario nuevoComentario)// agrega el nuevo comentario a la lista de comentarios de la pagina
        {

            listaDeComentarios.Add(nuevoComentario);

        }
        /*private void validarComentario(Comentario comentarioAValidar)// se encarga de determinar si el comentario es valido o no
        {
            if(listaDeComentadores.Contains(comentarioAValidar.duenio))//aqui verifica que el usuario que comento sea un comentador valido
            {
                comentarioAValidar.esValido = true;
            }
            else
            {
                comentarioAValidar.esValido = false;
            }
            //basicamente se en carga de darle estado de validez a los comentarios
        }*/
        

        
    }
}
