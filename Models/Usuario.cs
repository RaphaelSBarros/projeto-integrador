using System;

namespace Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public Usuario(
            string nome,
            string apelido,
            string email,
            string cpf,
            string endereco,
            string telefone,
            string senha
        ) {
            Nome = nome;
            Apelido = apelido;
            Email = email;
            Cpf = cpf;
            Endereco = endereco;
            Telefone = telefone;
            Senha = senha;

            Repositories.UsuarioRepository.addUsuarios(this);
        }

        public override string ToString(){
            return $"----\nNome: {Nome}\nApelido: {Apelido}\nEmail: {Email}\nCPF: {Cpf}\nEndereço: {Endereco}\nTelefone: {Telefone}\nLogin: {Cpf}\nSenha: {Senha}\n";
        }
        
    }
}