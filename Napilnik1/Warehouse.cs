namespace Napilnik1
{
    public class Warehouse : Storage
    {
        public void Ship(Good good, int count) => AddGood(good, count);
    }
}