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
            InitConexao();
            string query = "SELECT * FROM postagem";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter bdAdapter = new MySqlDataAdapter(command);
            DataSet dbDataSet = new DataSet();
            bdAdapter.Fill(dbDataSet, "postagem");
            DataTable table = dbDataSet.Tables["postagem"];

            foreach(DataRow row in table.Rows) {

                int code_postagem = Convert.ToInt32(row["Code_Postagem"].ToString());
                int id_status = Convert.ToInt32(row["ID_Status"].ToString());
                int id_usuario = Convert.ToInt32(row["ID_Usuario"].ToString());
                int id_bairro = Convert.ToInt32(row["ID_Bairro"].ToString());
                int code_problema = Convert.ToInt32(row["Code_Problema"].ToString());
                Image foto = Image.FromFile(row["Foto"].ToString());

                Models.Postagem postagem = new Models.Postagem();

                postagem.Code_Postagem = code_postagem;
                postagem.FK_ID_Status = id_status;
                postagem.FK_ID_Usuario = id_usuario;
                postagem.FK_ID_Bairro = id_bairro;
                postagem.FK_Code_Problema = code_problema;

                postagem.Logradouro = row["Logradouro"].ToString();
                postagem.Outros_Problemas = row["Outros_Problemas"].ToString();
                postagem.Foto = foto;
                postagem.Observacao = row["Observacao"].ToString();
                postagem.Data = row["Data"].ToString();
                postagens.Add(postagem);
            }
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

        public static void UpdatePostagem(int index, Models.Postagem postagem) { //ATUALIZAR as informações dos usuários no BANCO DE DADOS e na LISTA (cache) a partir do INDEX recebido.
            InitConexao();
            string query = "UPDATE postagem SET Code_Problema = @FK_Code_Problema, ID_Bairro = @FK_ID_Bairro, Logradouro = @Logradouro, Observacao = @Observacao, Foto = @Foto WHERE Code_Postagem = @Code_Postagem";
            MySqlCommand command = new MySqlCommand(query, conexao);

            if(postagem != null) {
                command.Parameters.AddWithValue("@Code_Postagem", index);
                command.Parameters.AddWithValue("@FK_Code_Problema", postagem.FK_Code_Problema);
                command.Parameters.AddWithValue("@FK_ID_Bairro", postagem.FK_ID_Bairro);
                command.Parameters.AddWithValue("@Logradouro", postagem.Logradouro);
                command.Parameters.AddWithValue("@Observacao", postagem.Observacao);
                command.Parameters.AddWithValue("@Foto", null);
                int rowsAffected = command.ExecuteNonQuery();
            
                if (rowsAffected > 0) {
                    postagens[index] = postagem;
                } else {
                    MessageBox.Show(rowsAffected.ToString());
                }
            } else {
                MessageBox.Show("Postagem não encontrada");
            }
            CloseConexao();
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
    }
}