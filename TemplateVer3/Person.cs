using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;

namespace CleanCodeWithDP.TemplateVer3
{
    public class Person : DAO
    {
        public Person()
        {
            this.mysql = new MySqlConnection(this.connectionString);
            dataSet = new System.Data.DataSet();
        }
        public override void GetAll()
        {
            string sql = "Select * from person";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mysql);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = mySqlCommand;
            adapter.Fill(dataSet, "person");
        }

        public override void Process()
        {
            Console.WriteLine("Person ---- ");

            DataTable dataTable = dataSet.Tables["person"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["Id"] + " " + row["FirstName"]);
            }
        }
    }
}
