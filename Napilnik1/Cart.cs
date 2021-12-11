using System;

namespace Napilnik1
{
    public sealed class Cart : Storage
    {
        private readonly Warehouse warehouse;

        public Cart(Warehouse warehouse) => this.warehouse = warehouse;

        public void Add(Good good, int count)
        {
            if (!warehouse.HasEnough(good, count))
                throw new InvalidOperationException();

            AddGood(good, count);                
        }

        public Order Order()
        {
            foreach(var pair in Goods)
            {
                if (!warehouse.TryRemoveGood(pair.Key, pair.Value))
                    throw new InvalidOperationException();
            } 

            return new Order();
        }
    }
}