using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.IocWithNTier
{
    public class BussinessLogic
    {
        private DataAccess _dataAccess;
        public BussinessLogic()
        {
            _dataAccess = FactoryDataAccess.CreateDataAccessIns();
        }

        public void Task1()
        {
            Console.WriteLine(_dataAccess.GetCustomerId(4));
        }
    }
}
