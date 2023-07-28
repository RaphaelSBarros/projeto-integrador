using System;
using System.Collections.Generic;

namespace Controllers {
    public static class UsuarioController {

        public static void AddUsuario(string nome, string nome_usuario, string email, string cpf, string senha, string telefone) {
            new Models.Usuario(nome, nome_usuario, email, cpf, senha, telefone);
        }

        public static List<Models.Usuario> ListarUsuarios() {
            return Models.Usuario.ListarUsuarios();
        }
        public static void UpdateUsuarios(int index, string nome, string nome_Usuario, string email, string cpf, string telefone, string senha) {
            Models.Usuario.UpdateUsuario(index, nome, nome_Usuario, email, cpf, telefone, senha);
        }


        public static Models.Usuario? GetUsuario(int index) {
            return Models.Usuario.GetUsuario(index);
        }

        public static void UpdateUsuario(int index, string nome, string nome_usuario, string email, string cpf, string senha, string telefone) {
            Models.Usuario.UpdateUsuario(index, nome, nome_usuario, email, cpf, senha, telefone);
        }

        public static void DeleteUsuario(int index) {
            Models.Usuario.DeleteUsuario(index);
        }
        
    }
    
}