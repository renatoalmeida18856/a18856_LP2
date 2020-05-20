using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    /// <summary>
    /// Nesta class temos todas as regioes , criaçao , ediçao e listagem
    /// </summary>
    class Regiao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Populacao { get; set; }

        // Ligaçao Base de dados
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        // Seleciona todos da tabela regioes
        public DataTable Select()
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable db = new DataTable();
            try
            {
                string sql = "SELECT * FROM regioes";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(db);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return db;
        }

        // Inserir regioes na tabela
        public bool Insert(Regiao r)
        {

            bool isSucess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO regioes (nome, populacao) VALUES(@nome, @populacao)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", r.Nome);
                cmd.Parameters.AddWithValue("@populacao", r.Populacao);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSucess;

        }

        public bool Update(Regiao r)
        {

            bool isSucess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE regioes SET nome=@nome, populacao=@populacao WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", r.Nome);
                cmd.Parameters.AddWithValue("@apelido", r.Populacao);
                cmd.Parameters.AddWithValue("@id", r.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSucess;

        }

    }
}
