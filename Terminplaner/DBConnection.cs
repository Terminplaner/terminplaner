using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace Terminplaner
{
    class DBConnection
    {

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand query = new MySqlCommand();

        public DBConnection(string server, string database, string userid, string pw)
        {
            connection.ConnectionString = "server=" + server + ";database=" + database + ";userid=" + userid + ";password=" + pw;
        }

        public void Open()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }

        public MySqlDataReader Execute(string Query)
        {
            query.CommandText = Query;
            query.Connection = connection;
            return query.ExecuteReader();
        }
    }
}