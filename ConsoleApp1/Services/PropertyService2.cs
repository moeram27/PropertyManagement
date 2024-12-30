using System;
using ConsoleApp1.Models;
using ConsoleApp1.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class PropertyService2
    {
        public List<Property> properties2 = new List<Property>();

        public void CreateApartment2(string title, string address, int numberOfRooms)
        {
            var apartment2 = new Apartment(IdGenerator.NextPropertyId(), title, address, numberOfRooms);
            properties2.Add(apartment2);
        }

        public void UpdatePropertyTitle2(int id, string title)
        {
            var property = properties2.FirstOrDefault(p => p.Id == id);
            if (property == null)
            {
                return;
            }
            property.Title = title;
            Console.WriteLine($"New Title: {property.Title} for Property ID= {property.Id}");
        }

        public void CreateLand2(string title, string address, int area, bool canBeFarmed)
        {
            var land2 = new Land(IdGenerator.NextPropertyId(), title, address,area, canBeFarmed);
            properties2.Add(land2);
        }

        public void CreateShop2(string title, string address, int area, string businessType)
        {
            var shop2 = new Shop(IdGenerator.NextPropertyId(), title, address, area, businessType);
            properties2.Add(shop2);
        }


        public void DisplayProperties()
        {
            foreach(var property in properties2)
            {
                Console.WriteLine($"{property.GetType().Name} ID: {property.Id}, Title: {property.Title}, Price: {property.Price}");
            }
        }

        public void PropertyPricing2()
        {
            Console.WriteLine("Property Prices are: ");
            foreach(var property in properties2.Where(p=>p.Price >=45_000 && p.Price <= 100_000))
            {
                Console.WriteLine($"Property with id {property.Id} has price {property.Price}");
            }
        }

        public void DisplyLandProperties()
        {
            foreach(var land in properties2.OfType<Land>())
            {
                Console.WriteLine($"Land Property with id {land.Id} that is priced at {land.Price} is: {land.Title}");
            }
        }

    }
}
