using System;

namespace InheritanceInterface
{
    partial class Program
    {
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

    }
}
