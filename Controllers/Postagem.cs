using System;
using System.Collections.Generic;

namespace Controllers {
    public static class PostagemController {

        public static void AddPostagem(int fk_id_usuario, int fk_code_problema, int fk_id_bairro, string logradouro, string observacao, Image foto) {
            new Models.Postagem(fk_id_usuario, fk_code_problema, fk_id_bairro, logradouro, observacao, foto);
        }

        // public static List<Models.Usuario> ListarUsuarios() {
        //     return Models.Usuario.ListarUsuarios();
        // }
        
        // public static Models.Usuario? GetUsuario(int index) {
        //     return Models.Usuario.GetUsuario(index);
        // }

        // public static void UpdateUsuario(int index, string nome, string nome_usuario, string email, string cpf, string senha, string telefone) {
        //     Models.Usuario.UpdateUsuario(index, nome, nome_usuario, email, cpf, senha, telefone);
        // }

        // public static void DeleteUsuario(int index) {
        //     Models.Usuario.DeleteUsuario(index);
        // }

        // public static void VerificaLogin(string cpf, string senha){
        //     Models.Usuario.VerificaLogin(cpf, senha);
        // }
        
    }
    
}