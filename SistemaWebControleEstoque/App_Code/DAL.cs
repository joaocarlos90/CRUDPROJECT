using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;


/// <summary>
/// Descrição resumida de DAL
/// </summary>
public class DAL
{
    public string server = "localhost";
    public string database = "estoque";
    public string user = "root";
    public string password = "";
    public string connectionString = "Server={0};Database={1};Uid={2};Pwd={3};";
    public MySqlConnection connection;

    public DAL()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
        connectionString = String.Format(connectionString, server, database, user, password);

        connection = new MySqlConnection(connectionString);

        connection.Open();
    }

    public DataTable RetDataTable(string sql)
    {
        DataTable dataTable = new DataTable();

        MySqlCommand command = new MySqlCommand(sql, connection);

        MySqlDataAdapter da = new MySqlDataAdapter(command);

        da.Fill(dataTable);

        return dataTable;
    }

    public void ExecutarComandoSQL(string sql)
    {
        MySqlCommand command = new MySqlCommand(sql, connection);

        command.ExecuteNonQuery();
    }
}