using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Sales
{
    class Record
    {
        public int SaleID { get; set; }
        public string Product_Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public DateTime date = DateTime.Now; 

    public Record()
        {

        }

        public Record(int SaleID, string Product_name, int Quantity, float Price, int Date)
        {

        }

        
    }
}
