using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using Models; // apagar, pois repositorie não pode ver models!!!

// obs: falta o telefone no banco de dados

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

        public static List<Models.Usuario> Sincronizar(){
            InitConexao();
            string query = "SELECT * FROM usuario"; // talvez mude
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter bdAdapter = new MySqlDataAdapter(command);

            DataSet dbDataSet = new DataSet();
            bdAdapter.Fill(dbDataSet, "usuario");
            DataTable table = dbDataSet.Tables["usuario"];

            foreach(DataRow row in table.Rows){
                int id = Convert.ToInt32(row["ID_Usuario"].ToString());
                Models.Usuario usuario = new Models.Usuario(); // possivelmente tem q tirar o construct
                usuario.Id = id;
                usuario.Nome = row["Nome"].ToString();
                usuario.Apelido = row["Nome_Usuario"].ToString();
                usuario.Email = row["Email"].ToString();
                usuario.Cpf = row["CPF"].ToString();
                usuario.Senha = row["Senha"].ToString();
                usuarios.Add(usuario);
            }
            CloseConexao();
            return usuarios;
        }
    
        public static void AddUsuario(Models.Usuario usuario){
            InitConexao();
            string query = "INSERT INTO usuario (ID_Usuario, Nome, CPF, Email, Nome_Usuario, Senha) VALUES (@ID_Usuario, @Nome, @CPF, @Email, @Nome_Usuario, @Senha)";
            MySqlCommand command = new MySqlCommand(query, conexao);
            if(usuario != null){
                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@CPF", usuario.Cpf);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Nome_Usuario", usuario.Apelido);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);

                int rowsAffected = command.ExecuteNonQuery();
                usuario.Id = Convert.ToInt32(command.LastInsertedId);

                if(rowsAffected > 0){
                    usuarios.Add(usuario);
                }else{
                    MessageBox.Show("Usuário não Cadastrado!");
                }
            }else{
                MessageBox.Show("Usuário não Cadastrado!");
            }
            CloseConexao();
        }

        public static void UpdateUsuario(int index, Models.Usuario usuario){
            InitConexao();
            string query = "UPDATE usuario SET Nome = @Nome, CPF = @CPF, Email = @Email, Nome_Usuario = @Nome_Usuario, Senha = @Senha WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(query, conexao);
            if(usuario != null){
                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@CPF", usuario.Cpf);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Nome_Usuario", usuario.Apelido);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);
                command.Parameters.AddWithValue("@ID_Usuario", usuario.Id);
                int rowsAffected = command.ExecuteNonQuery();
            
                if (rowsAffected > 0) {
                    usuarios[index] = usuario;
                }
                else {
                    MessageBox.Show(rowsAffected.ToString());
                }
            }else {
                MessageBox.Show("Usuário não encontrado");
            }
            CloseConexao();
        }
    
        public static void DeleteUsuario(int index){
            InitConexao();
            string query = "DELETE FROM usuario WHERE ID_Pessoa = @ID_Pessoa";
            MySqlCommand command = new MySqlCommand(query, conexao);
            int rowsAffected = command.ExecuteNonQuery();

            if(rowsAffected > 0){
                usuarios.RemoveAt(index);
            }else{
                MessageBox.Show("Usuário não excluído.");
            }

            CloseConexao();
        }
    }
}