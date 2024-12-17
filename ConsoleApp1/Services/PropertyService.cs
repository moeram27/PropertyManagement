using ConsoleApp1.Models;
using ConsoleApp1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class PropertyService
    {
        public List<Property> properties = new List<Property>();

        public void CreateApartment(string title, string address, int numberOfRooms)
        {
            var apartment = new Apartment(IdGenerator.NextPropertyId(), title, address, numberOfRooms);
            properties.Add(apartment);
        }

        public void UpdatePropertyTitle(int id, string title)
        {
            var property = properties.FirstOrDefault(p => p.Id == id);
            if (property == null)
            {
                return;
            }
            property.Title = title;
            Console.WriteLine($"Title: {property.Title}, Price: {property.Price}");

        }

        //public void RemoveProperty(int id)


        public void CreateLand(string title, string address, int area, bool canBeFarmed)
        {
            var land = new Land(IdGenerator.NextPropertyId(), title, address, area, canBeFarmed);
            properties.Add(land);
        }

        public void CreateShop(string title, string address, int area, string businessType)
        {
            var shop = new Shop(IdGenerator.NextPropertyId(), title, address, area, businessType);
            properties.Add(shop);
        }

        public void PropertyPricingUsingLinq()
        {
            Console.WriteLine("Properties with medium price are:");
            foreach (var property in properties.Where(p => p.Price >= 45_000 && p.Price <= 100_000))
            {
                Console.WriteLine("Title: {0}, Price: {1}", property.Title, property.Price);
            }

        }

        public void SortProprertyLand()
        {
            Console.WriteLine("Land properties are:");
            foreach (var land in properties.OfType<Land>())
            {
                Console.WriteLine("Title: {0}, Price: {1}, Address: {2}, Area: {3}, Can be Farmed: {4}", land.Title, land.Price, land.Address, land.Area, land.CanBeFarmed);
            }

        }

        public void DisplayProperties()
        {
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.GetType().Name} ID: {property.Id}, Title: {property.Title}, Price: {property.Price}");
            }
        }

        public void RemoveRandomUnpurchasedProperties(BuyerService buyerService)
        {
            List<Property> unpurchasedProperties = properties.Where(p => !buyerService.buyers.Any(b => b.OwnedProperties.Contains(p))).ToList();

            Random random = new Random();

           
            int firstIndex = random.Next(unpurchasedProperties.Count);
            int secondIndex;
            do
            {
                secondIndex = random.Next(unpurchasedProperties.Count);
            } while (firstIndex == secondIndex); 

            
            properties.Remove(unpurchasedProperties[firstIndex]);
            properties.Remove(unpurchasedProperties[secondIndex]);

            Console.WriteLine($"Removed properties: {unpurchasedProperties[firstIndex].Title} and {unpurchasedProperties[secondIndex].Title}");
        }
    }
}
