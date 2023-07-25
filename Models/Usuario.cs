
using System;

namespace Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public Usuario(
            string nome,
            string apelido,
            string email,
            string cpf,
            string telefone,
            string senha
        ) {
            Nome = nome;
            Apelido = apelido;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
            Senha = senha;

            Repositories.UsuarioRepository.addUsuarios(this);
        }

        public static Usuario? GetUsuario(int index){
            return Repositories.UsuarioRepository.GetUsuario(index);
        }

        public override string ToString(){
            return $"----\nNome: {Nome}\nApelido: {Apelido}\nEmail: {Email}\nCPF: {Cpf}\nTelefone: {Telefone}\nLogin: {Cpf}\nSenha: {Senha}\n";
        }
        
    }
}