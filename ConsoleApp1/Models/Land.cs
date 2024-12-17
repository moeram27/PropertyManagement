using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Land : Property
    {
        public int Area { get; set; }
        public bool CanBeFarmed { get; set; }

        public Land(int id, string title, string address, int area, bool canBeFarmed)
        : base(id, title, address)
        {
            Area = area;
            CanBeFarmed = canBeFarmed;
            CalculatePrice();
        }

        public override void CalculatePrice()
        {
            Price = Area * 3000;
        }
    }
}
