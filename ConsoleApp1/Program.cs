using ConsoleApp1.Services;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        PropertyService propertyService = new PropertyService();
        BuyerService buyerService = new BuyerService();

        
        propertyService.CreateApartment("Mansion", "Baabda Embassies", 7);
        propertyService.CreateApartment("Studio Apartment", "Ashrafiyeh, Monot", 1);
        propertyService.CreateApartment("Small Apartment", "Beirut, Hamra", 3);
        propertyService.CreateApartment("Medium Apartment", "Beirut, Ain Mrayse", 4);
        propertyService.CreateApartment("Big Apartment", "Beirut, Rawshe", 6);

        propertyService.CreateLand("Mazraait Tajeddine", "West Bekaa", 350, true);
        propertyService.CreateLand("Jroud Msheik", "Eastern Hermel", 85, false);


        propertyService.CreateShop("Bouzit bashir", "City Center", 40, "Food");
        propertyService.CreateShop("Mechanique Abed", "Ouzai", 70, "Repair");
        propertyService.CreateShop("Zara", "Beirut, DT", 50, "Retail");


        buyerService.CreateBuyer("Jamal Salman", 60000);
        buyerService.CreateBuyer("Omar J.", 10000);
        buyerService.CreateBuyer("A. Mokdad", 400000);

        propertyService.DisplayProperties();

        Console.WriteLine("\n");



        buyerService.PurchaseProperty(1, 1, propertyService.properties);
        Console.WriteLine("\n");
        buyerService.PurchaseProperty(1, 2, propertyService.properties);
        Console.WriteLine("\n");
        buyerService.PurchaseProperty(2, 6, propertyService.properties);
        Console.WriteLine("\n");
        buyerService.PurchaseProperty(3, 10, propertyService.properties);
        Console.WriteLine("\n");




        Console.WriteLine("\n");
        buyerService.DisplayBuyers();

        propertyService.SortProprertyLand();
        Console.WriteLine("\n");
        Console.WriteLine("\n");

        Console.WriteLine($"Properties for sale between 45000 and 100000: ") ;
        propertyService.PropertyPricingUsingLinq();
        Console.WriteLine("\n");
        Console.WriteLine("\n");


        propertyService.UpdatePropertyTitle(2, "Updated title");




    }
}