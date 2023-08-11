using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace Repositories {

    public class PostagemRepository {
        
        private static MySqlConnection conexao; // CONEXÃO com o BANCO DE DADOS
        static List<Models.Postagem> postagens = new List<Models.Postagem>(); // LISTA ou CACHE do SOFTWARE.
        
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

        public static List<Models.Postagem> Sincronizar(){ //SINCRONIZAR o banco de dados atual com o SOFTWARE.
            postagens.Clear();
            InitConexao();
            string query = "SELECT * FROM postagem";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter bdAdapter = new MySqlDataAdapter(command);
            DataSet dbDataSet = new DataSet();
            bdAdapter.Fill(dbDataSet, "postagem");
            DataTable table = dbDataSet.Tables["postagem"];
            MySqlDataReader reader = command.ExecuteReader();

            foreach(DataRow row in table.Rows) {
                reader.Read();
                
                int code_postagem = (int)reader["Code_Postagem"];
                int id_status = (int)reader["ID_Status"];
                int id_usuario = (int)reader["ID_Usuario"];
                int id_bairro = (int)reader["ID_Bairro"];
                int code_problema = (int)reader["Code_Problema"];
                byte[] foto = (byte[])reader["Foto"];

                Models.Postagem postagem = new Models.Postagem();

                postagem.Code_Postagem = code_postagem;
                postagem.FK_ID_Status = Convert.ToInt32(row["ID_Status"]);
                postagem.FK_ID_Usuario = Convert.ToInt32(row["ID_Usuario"]);
                postagem.FK_ID_Bairro = Convert.ToInt32(row["ID_Bairro"]);
                postagem.Logradouro = row["Logradouro"].ToString();
                postagem.FK_Code_Problema = Convert.ToInt32(row["Code_Problema"]);
                postagem.Foto = (byte[])row["Foto"];
                postagem.Observacao = row["Observacao"].ToString();
                postagem.Data = row["Data"].ToString();
                postagens.Add(postagem);
            }
            reader.Close();
            CloseConexao();
            return postagens;
        }
        
        public static Models.Postagem? GetPostagem(int index){ //PUXAR informações do usuário a partir do INDEX recebido.
            if(index < 0 || index >= postagens.Count) {
                return null;
            } else {
                return postagens[index];
            }
        }

        public static void AddPostagem(Models.Postagem postagem) { // ADICIONAR as informações do usuário no BANCO DE DADOS e na LISTA (cache).
            InitConexao();
            string query = "INSERT INTO postagem (ID_Usuario, Code_Problema, ID_Bairro, Logradouro, Observacao, Foto, Data) VALUES (@FK_ID_Usuario, @FK_Code_Problema, @FK_ID_Bairro, @Logradouro, @Observacao, @Foto, @Data)";
            MySqlCommand command = new MySqlCommand(query, conexao);
            if(postagem != null) {
                command.Parameters.AddWithValue("@FK_ID_Usuario", postagem.FK_ID_Usuario);
                command.Parameters.AddWithValue("@FK_Code_Problema", postagem.FK_Code_Problema);
                command.Parameters.AddWithValue("@FK_ID_Bairro", postagem.FK_ID_Bairro);
                command.Parameters.AddWithValue("@Logradouro", postagem.Logradouro);
                command.Parameters.AddWithValue("@Observacao", postagem.Observacao);
                command.Parameters.AddWithValue("@Foto", postagem.Foto);
                command.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy/MM/dd"));
                
                int rowsAffected = command.ExecuteNonQuery();
                postagem.Code_Postagem = Convert.ToInt32(command.LastInsertedId);

                if(rowsAffected > 0) {
                    postagens.Add(postagem);
                } else {
                    MessageBox.Show("ERRO AO CADASTRAR POSTAGEM");
                }
            } else {
                MessageBox.Show("ERRO AO CADASTRAR POSTAGEM");
            }
            CloseConexao();
        }

        public static List<Models.Postagem> ListarPostagens() { //LISTAR as informações dos usuários do BANCO DE DADOS.
            return postagens;
        }

        public static void DeletePostagem(int index) { //DELETAR as informações da Postagem no BANCO DE DADOS e na LISTA (cache) a partir do INDEX recebido.
            InitConexao();
            string query = "DELETE FROM postagem WHERE Code_Postagem = @Code_Postagem";
            MySqlCommand command = new MySqlCommand(query, conexao);
            command.Parameters.AddWithValue("@Code_Postagem", postagens[index].Code_Postagem);
            int rowsAffected = command.ExecuteNonQuery();

            if(rowsAffected > 0) {
                postagens.RemoveAt(index);
            } else {
                MessageBox.Show("Postagem não excluída.");
            }

            CloseConexao();
        }

        public static List<Models.Postagem> GetPostagens(int index){
            InitConexao();
            
            List<Models.Postagem> postagensUsuarioConectado = new List<Models.Postagem>();
            string query = "SELECT * FROM postagem WHERE ID_Usuario = @index";
            MySqlCommand command = new MySqlCommand(query, conexao);
            command.Parameters.AddWithValue("@index", index);

            MySqlDataAdapter bdAdapter = new MySqlDataAdapter(command);
            DataSet dbDataSet = new DataSet();
            bdAdapter.Fill(dbDataSet, "postagem");
            DataTable table = dbDataSet.Tables["postagem"];
            MySqlDataReader reader = command.ExecuteReader();

            foreach(DataRow row in table.Rows) {
                reader.Read();
                
                int code_postagem = (int)reader["Code_Postagem"];
                int id_status = (int)reader["ID_Status"];
                int id_usuario = (int)reader["ID_Usuario"];
                int id_bairro = (int)reader["ID_Bairro"];
                int code_problema = (int)reader["Code_Problema"];
                byte[] foto = (byte[])reader["Foto"];

                Models.Postagem postagem = new Models.Postagem();

                postagem.Code_Postagem = code_postagem;
                postagem.FK_ID_Status = Convert.ToInt32(row["ID_Status"]);
                postagem.FK_ID_Usuario = Convert.ToInt32(row["ID_Usuario"]);
                postagem.FK_ID_Bairro = Convert.ToInt32(row["ID_Bairro"]);
                postagem.Logradouro = row["Logradouro"].ToString();
                postagem.FK_Code_Problema = Convert.ToInt32(row["Code_Problema"]);
                postagem.Foto = (byte[])row["Foto"];
                postagem.Observacao = row["Observacao"].ToString();
                postagem.Data = row["Data"].ToString();
                postagensUsuarioConectado.Add(postagem);
            }
            reader.Close();
            CloseConexao();
            return postagensUsuarioConectado;
        }
    }
}