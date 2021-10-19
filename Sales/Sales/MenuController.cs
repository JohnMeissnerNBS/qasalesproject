using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public class MenuController
    {
        private static int Counter = 0;
        private IList<Record> records;

        public MenuController()
        {
            records = new List<Record>();
        }

        internal static void create()
        {
            Record records = new Record();

            records.SaleID = Counter;
            Console.WriteLine("Please enter a product name");
            records.Product_Name = "";

            Console.WriteLine("Please enter a quantity");
            Console.WriteLine("Please enter the price");
            Console.WriteLine("Please enter a date");

            records.Add(records);
            Counter++;

        }
    }
}
