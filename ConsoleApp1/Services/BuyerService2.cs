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
    public class BuyerService2
    {
        public List<Buyer> buyers2 = new List<Buyer>();

        public void CreateBuyers(string fullName, int credit)
        {
            var buyer2 = new Buyer(IdGenerator.NextBuyerId(), fullName, credit);
            buyers2.Add(buyer2);
        }

        public void PurchaseProperty2(int buyerId, int propertyId, List<Property> properties)
        {
            var buyer2 =buyers2.FirstOrDefault(b => b.Id == buyerId);
            var property2 = properties.FirstOrDefault(p => p.Id == propertyId);

            if (buyer2 != null && property2 != null)
            {
                buyer2.PurchaseProperty(property2);
            }
            else
            {
                return;
            }
        }

        public void DisplayBuyers2()
        {
            foreach (var buyer2 in buyers2)
            {
                Console.WriteLine($"Buyer: {buyer2.FullName}, Remaining Credit: {buyer2.Credit}");
                foreach (var property in buyer2.OwnedProperties)
                {
                    Console.WriteLine($"  Owned Property: {property.Title}, Price: {property.Price}");
                }
                Console.WriteLine();
            }
        }
    }
}
