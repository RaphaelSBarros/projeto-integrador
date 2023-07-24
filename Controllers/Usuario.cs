using System;
using System.Collections.Generic;

namespace Controllers
{
    public static class UsuarioController {

        public static void addUsuario(
            string nome,
            string apelido,
            string email,
            string cpf,
            string logradouro,
            string bairro,
            string numero,
            string telefone,
            string senha
        ){
            new Models.Usuario(nome, apelido, email, cpf, logradouro, bairro, numero, telefone, senha);
        }

        public static List<Models.Usuario> ListarUsuarios(){
            return Repositories.UsuarioRepository.ListarUsuarios();
        }

        public static Models.Usuario? GetUsuario(int index){
            return Repositories.UsuarioRepository.GetUsuario(index);
        }

        public static void AlterarUsuarios(int index, string nome, string apelido, string email, string cpf, string logradouro, string bairro, string numero, string telefone, string senha){
            Repositories.UsuarioRepository.AlterarUsuarios(index, nome, apelido, email, cpf, logradouro, bairro, numero, telefone, senha);
        }

        public static void removeUsuario(int index){
            Repositories.UsuarioRepository.removeUsuarios(index);
        }
    }
    
}