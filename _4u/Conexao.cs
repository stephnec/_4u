using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4u
{
    class Conexao
    {
        private static string servername = "localhost";
        private static string user = "root";
        private static string password = "";
        private static string database = "4u";

        public static MySqlConnection conexao = new MySqlConnection(
            string.Format(
                "server='{0}';User Id='{1}';password='{2}';database='{3}';",
                servername,
                user,
                password,
                database
            )
        );

        public static string PegarDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static void AbrirConexao()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public static bool AdicionarRegistro(string tabela, Dictionary<string, string> informacoes)
        {
            bool erro = false;

            try
            {
                List<string> colunas = informacoes.Keys.ToList();
                string colunasSql = String.Join(", ", colunas);

                List<string> valores = new List<string>();

                foreach (KeyValuePair<string, string> informacao in informacoes)
                {
                    string coluna = informacao.Key;
                    string valor = informacao.Value;

                    string valorComAspasSimples = string.Format(
                        "'{0}'",
                        valor
                    );

                    valores.Add(valorComAspasSimples);
                }

                string valoresSql = String.Join(", ", valores);

                string sql = string.Format(
                    "INSERT INTO {0} ({1}) VALUES ({2});",
                    tabela,
                    colunasSql,
                    valoresSql
                );

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                AbrirConexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao adicionar registro: " + e);

                erro = true;
            }
            finally
            {
                FecharConexao();
            }

            return erro;
        }

        public static bool EditarRegistro(string tabela, int id, Dictionary<string, string> informacoes)
        {
            bool erro = false;

            try
            {
                informacoes.Add("modificado", PegarDateTime());

                List<string> valores = new List<string>();

                foreach (KeyValuePair<string, string> informacao in informacoes)
                {
                    string coluna = informacao.Key;
                    string valor = informacao.Value;

                    string valorComAspasSimples = string.Format(
                        "{0} = '{1}'",
                        coluna,
                        valor
                    );

                    valores.Add(valorComAspasSimples);
                }

                string valoresSql = String.Join(", ", valores);

                string sql = string.Format(
                    "UPDATE {0} SET {1} WHERE id = '{2}';",
                    tabela,
                    valoresSql,
                    id
                );

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                AbrirConexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao editar registro: " + e);

                erro = true;
            }
            finally
            {
                FecharConexao();
            }

            return erro;
        }

        public static bool RemoverRegistro(string tabela, int id)
        {
            bool erro = false;

            try
            {
                string sql = string.Format(
                    "UPDATE {0} SET ativo = '0' WHERE id = '{1}';",
                    tabela,
                    id
                );
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                AbrirConexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao remover o registro: " + e);

                erro = true;
            }
            finally
            {
                FecharConexao();
            }

            return erro;
        }

        public static void BuscarRegistrosAtivos(string tabela, DataGridView dataGridView)
        {
            try
            {
                string sql = string.Format(
                    "SELECT * FROM {0} WHERE ativo = '1';",
                    tabela
                );
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                AbrirConexao();
                DataTable dataTable = new DataTable();
                dataTable.Load(comando.ExecuteReader());
                dataGridView.DataSource = dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar registros: " + e);
            }
            finally
            {
                FecharConexao();
            }
        }

        

        public static bool login(string tabela, string usuario, string senha)
        {
            try
            {
                string sql = string.Format(
                    "SELECT nome,senha,ativo FROM {0} WHERE nome='" + usuario + "' AND senha='" + senha + "' AND ativo = '1';",
                    tabela
                );
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                AbrirConexao();

                bool verifica = comando.ExecuteReader().HasRows;

                conexao.Close();

                return verifica; // Retorna o resultado da verificação depois de fechar a conexão
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao buscar registros: " + e);
            }
            finally
            {
                FecharConexao();
            }

            return false; // Deu algum erro e não estabeleceu a conexão nem retornou nada
        }

    }
}
