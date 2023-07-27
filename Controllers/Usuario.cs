using System;
using System.Collections.Generic;

namespace Controllers
{
    public static class UsuarioController {

        public static void Sincronizar(){
            Models.Usuario.Sincronizar();
        }

        public static void addUsuario(
            string nome,
            string apelido,
            string email,
            string cpf,
            string telefone,
            string senha
        ){
            new Models.Usuario(
                nome,
                apelido,
                email,
                cpf,
                telefone, 
                senha);
        }

        public static List<Models.Usuario> ListUsuarios(){
            return Models.Usuario.ListUsuarios();
        }
        public static void UpdateUsuarios(
            int index,
            string nome,
            string apelido,
            string email,
            string cpf,
            string telefone,
            string senha
        ){
            Models.Usuario.UpdateUsuario(
                index,
                nome,
                apelido,
                email,
                cpf,
                telefone,
                senha
            );
        }


        public static Models.Usuario? GetUsuario(int index){
            return Models.Usuario.GetUsuario(index);
        }

        

        public static void DeleteUsuario(int index){
            Models.Usuario.DeleteUsuario(index);
        }
    }
}