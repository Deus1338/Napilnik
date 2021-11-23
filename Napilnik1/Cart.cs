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
            if(warehouse.HasEnough(good, count))
                AddGood(good, count);
        }

        public Order Order()
        {
            foreach(Cell cell in Cells)
                warehouse.TryRemoveGood(cell.Good, cell.Count);

            return new Order();

        }
    }
}
