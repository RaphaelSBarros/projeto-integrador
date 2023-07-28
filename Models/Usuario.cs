using System;

namespace Models
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Nome { get; set; }
        public string Nome_Usuario { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public Usuario(){}
        public Usuario(
            string nome,
            string nome_usuario,
            string email,
            string cpf,
            string senha,
            string telefone
        ) {
            Nome = nome;
            Nome_Usuario = nome_usuario;
            Email = email;
            Cpf = cpf;
            Senha = senha;
            Telefone = telefone;

            Repositories.UsuarioRepository.AddUsuario(this);
        }

        public static void Sincronizar(){
            Repositories.UsuarioRepository.Sincronizar();
        }
        public static List<Models.Usuario> ListUsuarios(){
            return Repositories.UsuarioRepository.ListUsuarios();
        }

        public static Usuario? GetUsuario(int index){
            return Repositories.UsuarioRepository.GetUsuario(index);
        }

        public static List<Models.Usuario> ListarUsuarios(){
            return Repositories.UsuarioRepository.ListUsuarios();
        }

        public static void UpdateUsuario(
                int index, 
                string nome, 
                string cpf, 
                string email, 
                string nome_usuario, 
                string senha, 
                string telefone
            ){
            Models.Usuario usuario = Models.Usuario.GetUsuario(index);

            if(usuario != null){
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
            if(usuario != null){
                Repositories.UsuarioRepository.DeleteUsuario(index);
            }
        }

    }
}