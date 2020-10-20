using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.IocWithNTier
{
    public class FactoryDataAccess
    {
        public static DataAccess CreateDataAccessIns()
        {
            return new DataAccess();
        }

    }
}
