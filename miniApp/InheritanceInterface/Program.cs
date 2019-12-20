using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInterface
{
    class Program
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

        public interface IInventoryItem
        {
            string ProductName { get; set; }
            int QuantityInStock { get; set; }
        }

        public interface IRental : IInventoryItem
        {
            void Rent();
            void ReturnRental();
        }

        public interface IPurchase : IInventoryItem
        {
            void PurchaseItem();
        }

        public class InventoryItemModel : IInventoryItem
        {
            public string ProductName { get; set; }
            public int QuantityInStock { get; set; }
        }

        // Can Buy and Rent
        public class VehicleModel : InventoryItemModel, IPurchase, IRental
        {
            public decimal DealerFee { get; set; }

            public void PurchaseItem()
            {
                QuantityInStock -= 1;
                Console.WriteLine("Vehical has been purchased!");
            }

            public void Rent()
            {
                QuantityInStock -= 1;
                Console.WriteLine("Vehical has been rented!");
            }

            public void ReturnRental()
            {
                QuantityInStock += 1;
                Console.WriteLine("Vehical has been returned!");
            }
        }

        // Can only Buy
        public class BookModel : InventoryItemModel, IPurchase
        {
            public int NumberOfPages { get; set; }

            public void PurchaseItem()
            {
                QuantityInStock -= 1;
                Console.WriteLine("Booked has been purchased!");
            }
        }

        // Can only Rent
        public class HouseModel : InventoryItemModel, IRental
        {
           public void print()
            {
                Console.WriteLine("I am a rented house");
            }

            public void Rent()
            {
                QuantityInStock -= 1;
                Console.WriteLine("House has been rented");
            }

            public void ReturnRental()
            {
                QuantityInStock += 1;
                Console.WriteLine("I have been Returned");
            }
        }

    }
}
