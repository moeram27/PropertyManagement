using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Apartment : Property
    {
        public int NumberOfRooms { get; set; }

        public Apartment(int id, string title, string address, int numberOfRooms)
            : base(id, title, address)
        {
            NumberOfRooms = numberOfRooms;
            CalculatePrice();
        }

        public override void CalculatePrice()
        {
            Price = NumberOfRooms * 15000;
        }
    }

}
