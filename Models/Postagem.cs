using System;
// gustavo arruma sapoha ai tudo errado - "gustavo"

namespace Models {
    public class Postagem {
// FOREIGN KEYS
// `ID_Usuario` int(11) NOT NULL
// `Code_Problema` int(100) NOT NULL
// `ID_Bairro` int(11) NOT NULL
// `Code_Atendimento` int(11) NOT NULL


// `Code_Postagem` int(11) NOT NULL
// `Logradouro` varchar(100) NOT NULL
// `Outros_Problemas` varchar(100) NOT NULL
// `Foto` blob NOT NULL
// `Observacao` varchar(100) NOT NULL
// `Data` date NOT NULL
        public int Code_Postagem { get; set; }
        public string Logradouro { get; set; }
        public string Outros_Problemas { get; set; }
        public string Observacao { get; set; }
        public string Data { get; set; }

        public Postagem() {}

        public Postagem(string nome, string nome_usuario, string email, string cpf, string senha, string telefone) {
            Nome = nome;
            Nome_Usuario = nome_usuario;
            Email = email;
            Cpf = cpf;
            Senha = senha;
            Telefone = telefone;

            Repositories.UsuarioRepository.AddUsuario(this);
        }

        public static void Sincronizar() {
            Repositories.UsuarioRepository.Sincronizar();
        }

        public static List<Models.Usuario> ListUsuarios() {
            return Repositories.UsuarioRepository.ListUsuarios();
        }

        public static Usuario? GetUsuario(int index) {
            return Repositories.UsuarioRepository.GetUsuario(index);
        }

        public static List<Models.Usuario> ListarUsuarios() {
            return Repositories.UsuarioRepository.ListUsuarios();
        }

        public static void UpdateUsuario(int index, string nome, string nome_usuario,string cpf, string email, string senha, string telefone) {
            Models.Usuario usuario = Models.Usuario.GetUsuario(index);
            if(usuario != null) {
                usuario.Nome = nome;
                usuario.Nome_Usuario = nome_usuario;
                usuario.Email = email;
                usuario.Cpf = cpf;
                usuario.Senha = senha;
                usuario.Telefone = telefone;

                Repositories.UsuarioRepository.UpdateUsuario(index, usuario);
            }
        }

        public static void DeleteUsuario(int index){
            Models.Usuario usuario = Models.Usuario.GetUsuario(index);
            if(usuario != null) {
                Repositories.UsuarioRepository.DeleteUsuario(index);
            }
        }

    }

}