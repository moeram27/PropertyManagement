using ConsoleApp1.Models;
using ConsoleApp1.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp1.Services
{
    public class BuyerService
    {
        public List<Buyer> buyers = new List<Buyer>();

        public void CreateBuyer(string fullName, int credit)
        {
            var buyer = new Buyer(IdGenerator.NextBuyerId(), fullName, credit);
            buyers.Add(buyer);
        }

        public void PurchaseProperty(int buyerId, int propertyId, List<Property> properties)
        {
            var buyer = buyers.FirstOrDefault(b => b.Id == buyerId);
            var property = properties.FirstOrDefault(p => p.Id == propertyId);

            if (buyer != null && property != null)
            {
                buyer.PurchaseProperty(property);
            }
            else
            {
                Console.WriteLine("Buyer or property not found.");
            }
        }

        public void DisplayBuyers()
        {
            foreach (var buyer in buyers)
            {
                Console.WriteLine($"Buyer: {buyer.FullName}, Remaining Credit: {buyer.Credit}");
                foreach (var property in buyer.OwnedProperties)
                {
                    Console.WriteLine($"  Owned Property: {property.Title}, Price: {property.Price}");
                }
                Console.WriteLine(); 
            }
        }

        public void RemoveProperty()
        {

        }

    }
}
