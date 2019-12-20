using System;

namespace InheritanceInterface
{
    partial class Program
    {
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
