using System;
using System.Collections.Generic;

// Since the namespaces were not changed no need to add using statements 
// After moving intrfaces and models to their respiective folders
namespace InheritanceInterface
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rentals = new List<IRental>();
            List<IPurchase> purchases = new List<IPurchase>();
            
            var vehical = new VehicleModel { DealerFee = 30, ProductName = "Honda Civic", QuantityInStock = 3 };
            var book = new BookModel { NumberOfPages = 260, ProductName = "Lord Of The Rings", QuantityInStock = 50 };
            var house = new HouseModel { ProductName = "Malubu House", QuantityInStock = 10 };

            rentals.Add(vehical);
            rentals.Add(house);

            purchases.Add(book);
            purchases.Add(vehical);

            Console.WriteLine("Do you want to rent or purchase, type (rent or purchase): ");
            string decision = Console.ReadLine();
            Console.WriteLine();

            if (decision.Trim().ToLower() == "rent")
            {
                foreach (var item in rentals)
                {
                    Console.WriteLine($"item: {item.ProductName}");
                    Console.Write("Do you want to rent the item (yes/no): ");
                    string userChoiceToRent = Console.ReadLine();

                    if (userChoiceToRent.Trim().ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return the item (yes/no): ");
                    string userChoiceToReturn = Console.ReadLine();
                    Console.WriteLine();

                    if (userChoiceToReturn.Trim().ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchases)
                {
                    Console.WriteLine($"item: {item.ProductName}");
                    Console.Write("Do you want to purchase the item (yes/no): ");
                    string userChoiceToPurchase = Console.ReadLine();
                    Console.WriteLine();

                    if (userChoiceToPurchase.Trim().ToLower() == "yes")
                    {
                        item.PurchaseItem();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            
            Console.ReadLine();
        }

    }
}
