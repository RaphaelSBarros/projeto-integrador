using System;
// gustavo arruma sapoha ai tudo errado - "gustavo"

namespace Models {

    public class Postagem {
        public int Code_Postagem { get; set; }
        public string Logradouro { get; set; }
        public string Outros_Problemas { get; set; }
        public Image Foto { get; set; }
        public string Observacao { get; set; }
        public string Data { get; set; }

        // FOREIGN KEYS //
        public int FK_ID_Usuario { get; set; }
        public int FK_Code_Problema { get; set; }
        public int FK_ID_Bairro { get; set; }
        public int FK_ID_Status { get; set; }

        public Postagem(
            int fk_id_usuario,
            int fk_code_problema,
            int fk_id_bairro,
            string logradouro, 
            string observacao, 
            Image foto
        ){
            FK_ID_Usuario = fk_id_usuario;
            FK_Code_Problema = fk_code_problema;
            FK_ID_Bairro = fk_id_bairro;
            Logradouro = logradouro;
            Observacao = observacao;
            Foto = foto;

            Repositories.PostagemRepository.AddPostagem(this);
        }

        public static void Sincronizar() {
            Repositories.PostagemRepository.Sincronizar();
        }
        public static Postagem? GetPostagem(int index) {
            return Repositories.PostagemRepository.GetPostagem(index);
        }

        public static List<Models.Postagem> ListarPostagens() {
            return Repositories.PostagemRepository.ListarPostagens();
        }

        public static void UpdatePostagem(int fk_code_problema, int fk_id_bairro, string logradouro, string observacao, Image foto) {
            Models.Postagem postagem = Models.Postagem.GetPostagem(index);
            if(postagem != null) {

                postagem.FK_Code_Problema = fk_code_problema;
                postagem.FK_ID_Bairro = fk_id_bairro;
                postagem.Logradouro = logradouro;
                postagem.Observacao = observacao;
                postagem.Foto = foto;

                Repositories.PostagemRepository.UpdatePostagemPostagem(this);
            }
        }

        public static void DeletePostagem(int index){
            Models.Postagem postagem = Models.Postagem.GetPostagem(index);
            if(usuario != null) {
                Repositories.PostagemRepository.DeletePostagem(index);
             }
         }
    }
}