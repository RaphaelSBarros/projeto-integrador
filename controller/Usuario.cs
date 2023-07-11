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
            string endereco,
            string telefone,
            string senha
        ){
            new Models.Usuario(nome, apelido, email, cpf, endereco, telefone, senha);
        }

        public static List<Models.Usuario> ListarUsuarios(){
            return Repositories.UsuarioRepository.getUsuarios();
        }

        public static void AlterarUsuarios(int indice, string Anome, string Aapelido, string Aemail, string Acpf, string Aendereco, string Atelefone, string Asenha){
            Repositories.UsuarioRepository.AlterarUsuarios(indice, Anome, Aapelido, Aemail, Acpf, Aendereco, Atelefone, Asenha);
        }

        public static void removeUsuario(int indice){
            Repositories.UsuarioRepository.removeUsuarios(indice);
        }
        
    }
    
}