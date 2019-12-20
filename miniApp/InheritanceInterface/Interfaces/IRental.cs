namespace InheritanceInterface
{
    partial class Program
    {
        public interface IRental : IInventoryItem
        {
            void Rent();
            void ReturnRental();
        }

    }
}
