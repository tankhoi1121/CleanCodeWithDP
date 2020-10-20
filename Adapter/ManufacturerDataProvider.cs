using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Adapter
{
    public static class ManufacturerDataProvider
    {
        public static List<Manufacturer> GetData() =>
        new List<Manufacturer>
        {
            new Manufacturer { Name = "Lexus", City = "Japan", Year = 2020},
            new Manufacturer { Name = "Porche", City = "Germany", Year = 2020},
            new Manufacturer { Name = "Ford", City = "USA", Year = 2020},
            new Manufacturer { Name = "Subaru", City = "Japan", Year = 2020},
            new Manufacturer { Name = "Luxgen", City = "Taiwan", Year = 2020},
        };
    }
}
