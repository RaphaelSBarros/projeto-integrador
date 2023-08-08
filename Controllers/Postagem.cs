using System;
using System.Collections.Generic;

namespace Controllers {
    public static class PostagemController {

        public static void AddPostagem(int fk_id_usuario, int fk_code_problema, int fk_id_bairro, string logradouro, string observacao, Image foto) {
            new Models.Postagem(fk_id_usuario, fk_code_problema, fk_id_bairro, logradouro, observacao, foto);
        }

        public static List<Models.Postagem> ListarPostagens() {
            return Models.Postagem.ListarPostagens();
        }
        
        public static Models.Postagem? GetPostagem(int index) {
            return Models.Postagem.GetPostagem(index);
        }

        public static void UpdatePostagem(int fk_code_problema, int fk_id_bairro, string logradouro, string observacao, Image foto) {
            Models.Postagem.UpdatePostagem(fk_code_problema, fk_id_bairro, logradouro, observacao, foto);
        }

        public static void DeletePostagem(int index) {
            Models.Postagem.DeletePostagem(index);
        }
    }
}