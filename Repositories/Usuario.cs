using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using Models;

namespace Repositories
{
    public class UsuarioRepository {

        private static MySqlConnection conexao; // ok

        static List<Models.Usuario> usuarios = new List<Models.Usuario>(); // ok

        public static List<Models.Usuario> ListarUsuarios() { // ok
            return usuarios;
        }

        public static Models.Usuario? GetUsuario(int index){ // ok
            if(index < 0 || index >= usuarios.Count){
                return null;
            }else {
                return usuarios[index];
            }
        }

        public static void InitConexao(){ // ok
            string info = "server=localhost;database=resolville;user id=root;password=''";
            conexao = new MySqlConnection(info);
            try{
                conexao.Open();
            }
            catch{
                MessageBox.Show("Impossível estabelecer conexão com o banco");
            }
        }
         public static void CloseConexao(){ // ok
            conexao.Close();
        }

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

        // public static List<Models.Usuario> Sincronizar(){
        //     InitConexao();
        //     string query = "SELECT * FROM usuarios"; // talvez mude
        //     MySqlCommand command = new MySqlCommand(query, conexao);
        //     MySqlDataAdapter bdAdapter = new MySqlDataAdapter(command);

        //     DataSet dbDataSet = new DataSet();
        //     bdAdapter.Fill(dbDataSet, "usuarios");
        //     DataTable table = dbDataSet.Tables["usuarios"];

        //     foreach(DataRow row in table.Rows){
        //         int id = Convert.ToInt32(row["id"].ToString());
        //         Models.Usuario usuario = new Models.Usuario();
        //         usuario.Id = id;
        //         usuario.Idade = Convert.ToInt32(row["idade"].ToString());
        //     }
        // }
    }
}