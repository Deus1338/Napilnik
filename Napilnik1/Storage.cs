using System;
using System.Collections.Generic;

namespace Napilnik1
{
    public abstract class Storage
    {
        private readonly Dictionary<Good, int> goods;

        public Storage() => goods = new Dictionary<Good, int>();

        public IReadOnlyDictionary<Good, int> Goods => goods;

        protected void AddGood(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (!Has(good))
                goods.Add(good, count);
            else
                goods[good] += count;
        }

        public bool TryRemoveGood(Good good, int count)
        {
            if (!Has(good) || count <= 0)
                return false;

            if (!HasEnough(good, count))
                return false;

            RemoveGood(good, count);
            return true;
        }

        private void RemoveGood(Good good, int count)
        {
            if (goods[good] > count)
                goods[good] -= count;
            else if (goods[good] == count)
                goods.Remove(good);
        }

        private bool Has(Good good) => goods.ContainsKey(good);

        public bool HasEnough(Good good, int count)
        {
            if (!Has(good))
                return false;

            if (goods[good] >= count)
                return true;

            return false;
        }
    }
}