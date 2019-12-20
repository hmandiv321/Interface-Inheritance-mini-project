namespace InheritanceInterface
{
    partial class Program
    {
        public interface IPurchase : IInventoryItem
        {
            void PurchaseItem();
        }

    }
}
