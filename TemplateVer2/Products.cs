using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.OleDb;

namespace CleanCodeWithDP.TemplateVer2
{
    public class Products : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            DataTable dataTable = dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductNames"]);
            }
            Console.WriteLine();
        }

        public override void Select()
        {
            string sql = "select ProductNames from Products";
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            //Console.WriteLine(connection.State);            
            dataSet = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet, "Products");
        }
    }
}
