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
    /// Zona de gestao de pacientes, inserir, editar e listar os mesmos
    /// </summary>
    class Paciente
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Morada { get; set; }
        public string Genero { get; set; }
        public Boolean Infetado { get; set; }
        public int Recuperado { get; set; }
        public int Infecao { get; set; }
        public int Regiao{ get; set; }

        // Ligaçao Base de dados
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        // Seleciona todos da tabela pacientes
        public DataTable Select()
        {
               
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable db = new DataTable();
            try
            {
                string sql = "SELECT * FROM pacientes";
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
            
        // Inserir pacientes na tabela
        public bool Insert(Paciente p) {

            bool isSucess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try 
            {
                string sql = "INSERT INTO pacientes (nome, apelido, genero, data_nasc , morada, regiao, infetado, recuperado, infecao) VALUES(@nome_proprio, @apelido, @genero, @data_nasc, @morada, @regiao, @infetado, '', '')";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome_proprio", p.PrimeiroNome);
                cmd.Parameters.AddWithValue("@apelido", p.UltimoNome);
                cmd.Parameters.AddWithValue("@genero", p.Genero);
                cmd.Parameters.AddWithValue("@data_nasc", p.DataNasc);
                cmd.Parameters.AddWithValue("@morada", p.Morada);
                cmd.Parameters.AddWithValue("@regiao", p.Regiao);
                cmd.Parameters.AddWithValue("@infetado", p.Infetado);
                //cmd.Parameters.AddWithValue("@doenca", p.Infecao);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
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


        // Editar pacientes na tabela
        public bool Update(Paciente p)
        {

            bool isSucess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE pacientes SET nome=@nome_proprio, apelido=@apelido, genero=@genero, data_nasc=@data_nasc,morada=@morada, regiao=@regiao, infetado=@infetado, infecao=@doenca WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome_proprio", p.PrimeiroNome);
                cmd.Parameters.AddWithValue("@apelido", p.UltimoNome);
                cmd.Parameters.AddWithValue("@genero", p.Genero);
                cmd.Parameters.AddWithValue("@data_nasc", p.DataNasc);
                cmd.Parameters.AddWithValue("@morada", p.Morada);
                cmd.Parameters.AddWithValue("@regiao", p.Regiao);
                cmd.Parameters.AddWithValue("@infetado", p.Infetado);
                cmd.Parameters.AddWithValue("@doenca", p.Infecao);
                cmd.Parameters.AddWithValue("@id", p.Id);

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
