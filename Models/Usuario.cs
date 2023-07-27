using System;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public Usuario(){}
        public Usuario(
            string nome,
            string apelido,
            string email,
            string cpf,
            string telefone,
            string senha
        ) {
            this.Nome = nome;
            this.Apelido = apelido;
            this.Email = email;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Senha = senha;

            Repositories.UsuarioRepository.AddUsuario(this); // tem q add dps lá no repositorio o telefone
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

        public static void UpdateUsuario(
            int index,
            string nome,
            string apelido,
            string email,
            string cpf,
            string telefone,
            string senha
        ){
            Usuario usuario = Usuario.GetUsuario(index);
            if(usuario != null){
                usuario.Nome = nome;
                usuario.Apelido = apelido;
                usuario.Email = email;
                usuario.Cpf = cpf;
                usuario.Telefone = telefone;
                usuario.Senha = senha;

                Repositories.UsuarioRepository.UpdateUsuario(index, usuario);
            }
        }

        public static void DeleteUsuario(int index){
            Usuario usuario = Usuario.GetUsuario(index);
            if(usuario != null){
                Repositories.UsuarioRepository.DeleteUsuario(index);
            }
        }
    }
}