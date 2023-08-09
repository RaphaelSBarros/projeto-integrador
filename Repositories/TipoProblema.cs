using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace Repositories {

    public class Tipo_ProblemaRepository {
        
        private static MySqlConnection conexao; // CONEXÃO com o BANCO DE DADOS
        static List<Models.Tipo_Problema> problemas = new List<Models.Tipo_Problema>(); // LISTA ou CACHE do SOFTWARE.
        
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

        public static List<Models.Tipo_Problema> Sincronizar(){ // SINCRONIZAR o banco de dados atual com o SOFTWARE.
            problemas.Clear();
            InitConexao();
            string query = "SELECT * FROM problema";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter bdAdapter = new MySqlDataAdapter(command);
            DataSet dbDataSet = new DataSet();
            bdAdapter.Fill(dbDataSet, "problema");
            DataTable table = dbDataSet.Tables["problema"];

            foreach(DataRow row in table.Rows) {
                Models.Tipo_Problema tipo_problema = new Models.Tipo_Problema();
                int code_problema = Convert.ToInt32(row["Code_Problema"].ToString());
                tipo_problema.Problema_Nome = (row["Problema"].ToString());
                tipo_problema.Code_Problema = code_problema;

                problemas.Add(tipo_problema);
            }
            CloseConexao();
            return problemas;
        }
        
        // INFORMAÇÕES DO TIPO PROBLEMA //
        public static List<Models.Tipo_Problema> ListarProblemas() { // LISTAR as informações dos tipos de problemas do BANCO DE DADOS.
            return problemas;
        }

        public static Models.Tipo_Problema? GetTipo_Problema(int index){ // PUXAR informações do usuário a partir do INDEX recebido.
            InitConexao();

            string query = "SELECT Code_Problema, Problema FROM problema WHERE Code_Problema = @index";
            MySqlCommand command = new MySqlCommand(query, conexao);
            command.Parameters.AddWithValue("@index", index);

            MySqlDataReader reader = command.ExecuteReader();
            bool result = reader.HasRows;

            if(result){
                Models.Tipo_Problema? tipo_Problema = new Models.Tipo_Problema();
                reader.Read();

                tipo_Problema.Code_Problema = (int)reader["Code_Problema"];
                tipo_Problema.Problema_Nome = (string)reader["Problema"];

                reader.Close();
                CloseConexao();
                return tipo_Problema;

            }else{
                reader.Close();
                CloseConexao();
                return null;
            }
        }
    }
}