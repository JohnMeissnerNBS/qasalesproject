using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Sales
{
    class Record
    {
        public int SaleID;
        public string Product_Name;
        public int Quantity;
        public float Price;
        public string Date;

        public Record()
        {

        }

        public Record(int SaleID, string Product_name, int Quantity, float Price, string Date)
        {

        }

        internal void Add(Record records)
        {
            throw new NotImplementedException();
        }
    }
}
