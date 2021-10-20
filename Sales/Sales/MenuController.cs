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
            records = new List<Record>(); //initializing list
        }

        static internal void Create() //create new record
        {
            var now = DateTime.Now;
            Record records = new Record();

            records.SaleID = Counter;

            Console.WriteLine("Please enter a product name");
            records.Product_Name = Console.ReadLine(); 
           

            Console.WriteLine("Please enter a quantity");
            records.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price");
            records.Price = float.Parse(Console.ReadLine());

            records.date = DateTime.Now;
            


            Record.Add(records); //add to list
            Counter++;

        }

        

        static internal void ReadSalesbyyear()
        {
            //need to add in 

        }

        static internal void ReadSalesbymonthandyear()

        {


        }

        static internal void ReadTotalsalesbyyear()

        {


        }

        static internal void ReadTotalsalesbyyearandmonth()

        {


        }
    }
}
