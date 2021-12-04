using System;
using System.Collections.Generic;

namespace Napilnik1
{
    public abstract class Storage
    {
        private readonly List<Cell> cells;

        public Storage()
        {
            cells = new List<Cell>();
        }

        public IReadOnlyList<IReadOnlyCell> Cells => cells;

        private void Add(Cell cell)
        {
            if (!Has(cell.Good, out int index))
                cells.Add(cell);
            else
                cells[index].Merge(cell);
        }

        protected void AddGood(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Add(new Cell(good, count));
        }

        public bool TryRemoveGood(Good good, int count)
        {
            if (!Has(good, out int index) || count <= 0)
                return false;

            Cell existedCell = cells[index];

            if (!HasEnough(good, count))
                return false;

            RemoveGood(count, existedCell);
            return true;
        }

        private void RemoveGood(int count, Cell existedCell)
        {
            if (existedCell.Count > count)
                existedCell.Count -= count;
            else if (existedCell.Count == count)
                cells.Remove(existedCell);
        }

        private bool Has(Good good, out int index)
        {
            index = cells.FindIndex(existedCell => existedCell.Good == good);

            return index != -1;
        }

        public bool HasEnough(Good good, int count)
        {
            if (!Has(good, out int goodIndex))
                return false;

            if (Cells[goodIndex].Count >= count)
                return true;

            return false;
        }
    }
}