using System;
using System.Collections.Generic;
using System.Data;
//using MySqlConnector;
using Models;

namespace Repositories
{
    public class UsuarioRepository {

        //private static MySqlConnection conexao;

        static List<Models.Usuario> usuarios = new List<Models.Usuario>();
        
        public static void addUsuarios(Models.Usuario user) {
            usuarios.Add(user);
        }

        public static List<Models.Usuario> ListarUsuarios() {
            return usuarios;
        }

        public static Models.Usuario? GetUsuario(int index){
            if(index < 0 || index >= usuarios.Count){
                return null;
            }else {
                return usuarios[index];
            }
        }

        /*public static void InitConexao(){
            string info = "server=localhost;database=resolville;user id=root;password=''";
            conexao = new MySqlConnection(info);
            try{
                conexao.Open();
            }
            catch{
                MessageBox.Show("Impossível estabelecer conexão com o banco");
            }
        }
         public static void CloseConexao(){
            conexao.Close();
        }*/

        public static void AlterarUsuarios(int index, string nome, string apelido, string email, string cpf, string telefone, string senha){
            usuarios[index].Nome = nome;
            usuarios[index].Apelido = apelido;
            usuarios[index].Email = email;
            usuarios[index].Cpf = cpf;
            usuarios[index].Telefone = telefone;
            usuarios[index].Senha = senha;
        }

        public static void removeUsuarios(int index){
            usuarios.RemoveAt(index);
        }
    }
}