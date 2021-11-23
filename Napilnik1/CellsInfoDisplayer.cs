using System;

namespace Napilnik1
{
    public class CellsInfoDisplayer
    {
        public static void ShowContentInfo(CellsSet set)
        {
            Console.Write("\n");
            foreach (Cell cell in set.Cells)
            {
                Console.WriteLine(cell.Info);
            }
        }
    }
}