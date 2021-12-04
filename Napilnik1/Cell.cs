using System;

namespace Napilnik1
{
    public class Cell : IReadOnlyCell
    {
        public Cell(Good good, int count)
        {
            Good = good;
            Count = count;
        }

        public Good Good { get; private set; }

        public int Count { get; set; }

        public string Info => $"{Good.Name} : {Count.ToString()}";

        public void Merge(Cell newCell)
        {
            if(newCell.Good != Good)
                throw new InvalidOperationException();

            Count += newCell.Count;
        }
    }

    public interface IReadOnlyCell
    {
        int Count { get; }
    }
}
