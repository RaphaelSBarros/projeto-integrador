using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace Repositories {

    public class UsuarioRepository {
        static Models.Usuario usuarioConectado = new Models.Usuario(); // LISTA ou CACHE do SOFTWARE em relação ao USUÁRIO conectado no momento.
        static List<Models.Usuario> usuarios = new List<Models.Usuario>(); // LISTA ou CACHE do SOFTWARE em relação aos USUÁRIOS.

        private static MySqlConnection conexao; // CONEXÃO com o BANCO DE DADOS
        
        // BANCO DE DADOS //
        public static void InitConexao(){ // INICIAR conexão com o BANCO DE DADOS.
            string info = "server=localhost;database=resolville;user id=root;password=''";
            conexao = new MySqlConnection(info);

            try {
                conexao.Open();
            } catch {
                MessageBox.Show("Impossível estabelecer conexão com o banco");
            }
        }

        public static void CloseConexao(){ // FINALIZAR conexão com o BANCO DE DADOS.
            conexao.Close();
        }

        public static List<Models.Usuario> Sincronizar(){ // SINCRONIZAR o banco de dados atual com o SOFTWARE.
            InitConexao();
            string query = "SELECT * FROM usuario";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter bdAdapter = new MySqlDataAdapter(command);
            DataSet dbDataSet = new DataSet();
            bdAdapter.Fill(dbDataSet, "usuario");
            DataTable table = dbDataSet.Tables["usuario"];

            foreach(DataRow row in table.Rows) {
                int id_usuario = Convert.ToInt32(row["ID_Usuario"].ToString());
                Models.Usuario usuario = new Models.Usuario();
                usuario.ID_Usuario = id_usuario;
                usuario.Nome = row["Nome"].ToString();
                usuario.Nome_Usuario = row["Nome_Usuario"].ToString();
                usuario.Email = row["Email"].ToString();
                usuario.Cpf = row["CPF"].ToString();
                usuario.Senha = row["Senha"].ToString();
                usuario.Telefone = row["Telefone"].ToString();
                usuarios.Add(usuario);
            }
            CloseConexao();
            return usuarios;
        }
        
        // INFORMAÇÕES DO USUÁRIO //
        public static Models.Usuario? GetUsuario(int index){ // PUXAR informações do usuário a partir do INDEX recebido.
            if(index < 0 || index >= usuarios.Count) {
                return null;
            } else {
                return usuarios[index];
            }
        }

        public static void AddUsuario(Models.Usuario usuario) { // ADICIONAR as informações do usuário no BANCO DE DADOS e na LISTA (cache).
            InitConexao();
            string query = "INSERT INTO usuario (Nome, CPF, Email, Nome_Usuario, Senha, Telefone) VALUES (@Nome, @CPF, @Email, @Nome_Usuario, @Senha, @Telefone)";
            MySqlCommand command = new MySqlCommand(query, conexao);
            if(usuario != null) {
                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@Nome_Usuario", usuario.Nome_Usuario);
                command.Parameters.AddWithValue("@CPF", usuario.Cpf);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);
                command.Parameters.AddWithValue("@Telefone", usuario.Telefone);


                int rowsAffected = command.ExecuteNonQuery();
                usuario.ID_Usuario = Convert.ToInt32(command.LastInsertedId);

                if(rowsAffected > 0) {
                    usuarios.Add(usuario);
                } else {
                    MessageBox.Show("Usuário não foi Cadastrado!");
                }
            } else {
                MessageBox.Show("Usuário não foi Cadastrado!");
            }
            CloseConexao();
        }

        public static List<Models.Usuario> ListarUsuarios() { // LISTAR as informações dos usuários do BANCO DE DADOS.
            return usuarios;
        }

        public static void UpdateUsuario(int index, Models.Usuario usuario) { // ATUALIZAR as informações dos usuários no BANCO DE DADOS e na LISTA (cache) a partir do INDEX recebido.
            InitConexao();
            string query = "UPDATE usuario SET Nome = @Nome, CPF = @CPF, Email = @Email, Nome_Usuario = @Nome_Usuario, Senha = @Senha, Telefone = @Telefone WHERE ID_Usuario = @ID_Usuario";
            MySqlCommand command = new MySqlCommand(query, conexao);

            if(usuario != null) {
                command.Parameters.AddWithValue("@ID_Usuario", usuario.ID_Usuario);
                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@Nome_Usuario", usuario.Nome_Usuario);
                command.Parameters.AddWithValue("@CPF", usuario.Cpf);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);
                command.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                int rowsAffected = command.ExecuteNonQuery();
            
                if (rowsAffected > 0) {
                    usuarios[index] = usuario;
                } else {
                    MessageBox.Show(rowsAffected.ToString());
                }
            } else {
                MessageBox.Show("Usuário não foi encontrado");
            }
            CloseConexao();
        }

        public static void DeleteUsuario(int index) { // DELETAR as informações do usuário no BANCO DE DADOS e na LISTA (cache) a partir do INDEX recebido.
            InitConexao();
            string query = "DELETE FROM usuario WHERE ID_Usuario = @ID_Usuario";
            MySqlCommand command = new MySqlCommand(query, conexao);
            command.Parameters.AddWithValue("@ID_Usuario", usuarios[index].ID_Usuario);
            int rowsAffected = command.ExecuteNonQuery();

            if(rowsAffected > 0) {
                usuarios.RemoveAt(index);
            } else {
                MessageBox.Show("Usuário não excluído.");
            }

            CloseConexao();
        }

        // INFORMAÇÕES DO USUÁRIO CONECTADO //
        public static bool VerificaLogin(string cpf, string senha){
            InitConexao();

            string query = "SELECT ID_Usuario, Nome, Nome_Usuario, CPF, Senha FROM usuario WHERE CPF = @cpf AND Senha = @senha";
            MySqlCommand command = new MySqlCommand(query, conexao);
            command.Parameters.AddWithValue("@cpf", cpf);
            command.Parameters.AddWithValue("@senha", senha);

            MySqlDataReader reader = command.ExecuteReader();
            bool result = reader.HasRows;

            if(result){
                while (reader.Read())
                {
                    usuarioConectado.ID_Usuario = (int)reader["ID_Usuario"];
                    usuarioConectado.Nome = (string)reader["Nome"];
                    usuarioConectado.Nome_Usuario = (string)reader["Nome_Usuario"];
                }

                reader.Close();
                CloseConexao();
                return true;
            }
            
            reader.Close();
            CloseConexao();
            return false;
        }

        public static Models.Usuario ListarUsuarioConectado(){
            return usuarioConectado;
        }
    }
}