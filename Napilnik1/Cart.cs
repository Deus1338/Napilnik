namespace Napilnik1
{
    public class Cart : CellsSet
    {
        private readonly Warehouse warehouse;

        public Cart(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void Add(Good good, int count)
        {
            warehouse.TryRemoveGood(good, count);
            AddGood(good, count);
        }

        public Order Order()
        {
            return new Order();
        }
    }
}
