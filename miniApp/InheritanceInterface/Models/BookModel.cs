using System;

namespace InheritanceInterface
{
    partial class Program
    {
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

    }
}
