using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using MySqlConnector;

namespace CleanCodeWithDP.TemplateVer2
{
    public class Categories : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryNames"]);
            }
        }

        public override void Select()
        {
            string sql = "select CategoryNames from Categories";
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            //Console.WriteLine(connection.State);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categories");
        }
    }
}
