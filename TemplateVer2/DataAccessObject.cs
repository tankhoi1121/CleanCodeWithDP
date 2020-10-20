using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CleanCodeWithDP.TemplateVer2
{
    public abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            // Make sure mdb is available to app

            connectionString = "server=localhost;port=3306;user=root;password=Tankhoi@123;database=db1";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method' 

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
