namespace Napilnik1
{
    public class Warehouse : CellsSet
    {
        public void Ship(Good good, int count) => AddGood(good, count);
    }
}