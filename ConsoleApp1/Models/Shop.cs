using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Shop : Property
    {
        public int Area { get; set; }
        public string BusinessType { get; set; }

        public Shop(int id, string title, string address, int area, string businessType)
    : base(id, title, address)
        {
            Area = area;
            BusinessType = businessType;
            CalculatePrice();
        }

        public override void CalculatePrice()
        {
            Price = Area > 50 ? 120000 : 80000;
        }
    }
}
