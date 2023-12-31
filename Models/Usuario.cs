using System;

namespace Models {
    public class Usuario {
        public int ID_Usuario { get; set; }
        public string Nome { get; set; }
        public string Nome_Usuario { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public byte[]? Foto { get; set; }

        public Usuario() {}

        public Usuario(string nome, string nome_usuario, string email, string cpf, string senha, string telefone, byte[]? foto) {
            Nome = nome;
            Nome_Usuario = nome_usuario;
            Email = email;
            Cpf = cpf;
            Senha = senha;
            Telefone = telefone;
            Foto = foto;

            Repositories.UsuarioRepository.AddUsuario(this);
        }

        public static void Sincronizar() {
            Repositories.UsuarioRepository.Sincronizar();
        }

        public static Usuario? GetUsuario(int index) {
            return Repositories.UsuarioRepository.GetUsuario(index);
        }

        public static List<Models.Usuario> ListarUsuarios() {
            return Repositories.UsuarioRepository.ListarUsuarios();
        }

        public static void UpdateUsuario(int index, Models.Usuario upUsuario) {
            Repositories.UsuarioRepository.UpdateUsuario(index, upUsuario);
        }

        public static void DeleteUsuario(int index){
            Models.Usuario usuario = Models.Usuario.GetUsuario(index);
            if(usuario != null) {
                Repositories.UsuarioRepository.DeleteUsuario(index);
            }
        }

        public static bool VerificaLogin(string cpf, string senha){
            return Repositories.UsuarioRepository.VerificaLogin(cpf, senha);
        }

        public static Models.Usuario ListarUsuarioConectado(){
            return Repositories.UsuarioRepository.ListarUsuarioConectado();
        }
    }
}