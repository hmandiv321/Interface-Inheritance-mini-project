namespace InheritanceInterface
{
    partial class Program
    {
        public class InventoryItemModel : IInventoryItem
        {
            public string ProductName { get; set; }
            public int QuantityInStock { get; set; }
        }

    }
}
