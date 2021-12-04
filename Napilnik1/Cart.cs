using System;

namespace Napilnik1
{
    public class Cart : Storage
    {
        private readonly Warehouse warehouse;

        public Cart(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void Add(Good good, int count)
        {
            if (!warehouse.HasEnough(good, count))
                throw new InvalidOperationException();

            AddGood(good, count);                
        }

        public Order Order()
        {
            foreach(Cell cell in Cells)
            {
                if (!warehouse.TryRemoveGood(cell.Good, cell.Count))
                    throw new InvalidCastException(nameof(cell));
            } 

            return new Order();

        }
    }
}
