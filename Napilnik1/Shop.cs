namespace Napilnik1
{
    public sealed class Shop
    {
        private readonly Warehouse warehouse;

        public Shop(Warehouse warehouse) => this.warehouse = warehouse;

        public Cart CreateCart() => new Cart(warehouse);
    }
}