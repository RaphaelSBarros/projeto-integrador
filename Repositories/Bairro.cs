using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace Repositories {

    public class BairroRepository {
        
        private static MySqlConnection conexao; // CONEXÃO com o BANCO DE DADOS
        static List<Models.Bairro> bairros = new List<Models.Bairro>(); // LISTA ou CACHE do SOFTWARE.
        
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

        public static List<Models.Bairro> Sincronizar(){ // SINCRONIZAR o banco de dados atual com o SOFTWARE.
            bairros.Clear();
            InitConexao();
            string query = "SELECT * FROM bairro";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter bdAdapter = new MySqlDataAdapter(command);
            DataSet dbDataSet = new DataSet();
            bdAdapter.Fill(dbDataSet, "bairro");
            DataTable table = dbDataSet.Tables["bairro"];

            foreach(DataRow row in table.Rows) {
                Models.Bairro bairro = new Models.Bairro();
                int id_bairro = Convert.ToInt32(row["ID_Bairro"].ToString());
                bairro.Bairro_Nome = (row["Bairro"].ToString());
                bairro.ID_Bairro = id_bairro;

                bairros.Add(bairro);
            }
            CloseConexao();
            return bairros;
        }
        
        // INFORMAÇÕES DO BAIRRO //
        public static List<Models.Bairro> ListarBairros() { // LISTAR as informações dos bairros do BANCO DE DADOS.
            return bairros;
        }

        public static Models.Bairro? GetBairro(int index){ // PUXAR informações do usuário a partir do INDEX recebido.
            InitConexao();

            string query = "SELECT ID_Bairro, Bairro FROM bairro WHERE ID_Bairro = @index";
            MySqlCommand command = new MySqlCommand(query, conexao);
            command.Parameters.AddWithValue("@index", index);

            MySqlDataReader reader = command.ExecuteReader();
            bool result = reader.HasRows;

            if(result){
                Models.Bairro? bairro = new Models.Bairro();

                while (reader.Read())
                {
                    bairro.ID_Bairro = (int)reader["ID_Bairro"];
                    bairro.Bairro_Nome = (string)reader["Bairro"];
                }

                reader.Close();
                CloseConexao();
                return bairro;

            }else{
                reader.Close();
                CloseConexao();
                return null;
            }
        }
    }
}