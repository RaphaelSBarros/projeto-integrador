using System;
using System.Collections.Generic;
using Models;

namespace Repositories
{
    public class UsuarioRepository {

        static List<Models.Usuario> Usuarios = new List<Models.Usuario>();
        
        public static void addUsuarios(Models.Usuario user) {
            Usuarios.Add(user);
        }

        public static List<Models.Usuario> getUsuarios() {
            return Usuarios;
        }

        public static void AlterarUsuarios(int indice, string Anome, string Aapelido, string Aemail, string Acpf, string Aendereco, string Atelefone, string Asenha){
            Usuarios[indice].Nome = Anome;
            Usuarios[indice].Apelido = Aapelido;
            Usuarios[indice].Email = Aemail;
            Usuarios[indice].Cpf = Acpf;
            Usuarios[indice].Endereco = Aendereco;
            Usuarios[indice].Telefone = Atelefone;
            Usuarios[indice].Senha = Asenha;
        }

        public static void removeUsuarios(int indice){
            Usuarios.RemoveAt(indice);
        }
    }
}