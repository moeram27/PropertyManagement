using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class Property
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }


        public Property(int id, string title, string address)
        {
            Id = id;
            Title = title;
            Address = address;

        }

        public abstract void CalculatePrice();

    }

}
