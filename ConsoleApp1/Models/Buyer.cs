using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Credit { get; set; }
        public List<Property> OwnedProperties { get; set; } = new List<Property>();


        public Buyer(int id, string fullName, int credit)
        {
            Id = id;
            FullName = fullName;
            Credit = credit;
        }

        public void PurchaseProperty(Property property)
        {
            if (Credit >= property.Price)
            {
                Credit -= property.Price;
                OwnedProperties.Add(property);

                Console.WriteLine($"{property.GetType().Name} with ID {property.Id} was purchased by {FullName} for {property.Price}");
            }
            else
            {
                Console.WriteLine($"{FullName} does not have enough credit to purchase {property.Title}.");
            }
        }
    }
}
