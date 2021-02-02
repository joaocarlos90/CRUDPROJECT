using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace empresa.DAL
{
    public class CONEXAO
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand comando;

        //Contrutor
        public CONEXAO()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            comando = conn.CreateCommand();
        }

        //Método conectar
        public SqlConnection Conectar()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }

        //Método desconectar
        public void Desconectar()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }



        protected DataTable RetornaTabela(string query)
        {
            DataTable retorno = new DataTable();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            Conectar();

            da.Fill(retorno);

            Desconectar();

            return retorno;
        }
        public int ExecutarComando(string query, Dictionary<string, object> parametros = null)
        {

            SqlCommand cmd = new SqlCommand(query, conn);

            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }


            Conectar();


            int retorno = cmd.ExecuteNonQuery();

            Desconectar();

            return retorno;
        }

        

        
    }
}
