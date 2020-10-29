using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;

namespace CleanCodeWithDP.TemplateVer3
{
    public abstract class DAO
    {
        protected string connectionString = @"server=localhost;port=3306;user=root;password=Tankhoi@123;database=db1";
        protected MySqlConnection mysql;
        protected DataSet dataSet;

        public void Connect()
        {
            mysql.Open();
        }
        public abstract void GetAll();
        public abstract void Process();

        public void Disconnect()
        {
            mysql.Close();
        }
    }
}
