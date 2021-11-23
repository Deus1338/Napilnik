using System;

namespace Napilnik1
{
    class Program
    {
        static void Main(string[] args)
        {
            Good cup = new Good("Cup 0.5 l");
            Good plate = new Good("Plate 15 cm");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Ship(cup, 100);
            warehouse.Ship(plate, 1);

            CellsInfoDisplayer.ShowContentInfo(warehouse);

            Cart cart = shop.CreateCart();

            cart.Add(cup, 4);
            cart.Add(plate, 1);

            

            Console.WriteLine(cart.Order().Paylink);

            CellsInfoDisplayer.ShowContentInfo(cart);
            CellsInfoDisplayer.ShowContentInfo(warehouse);

            Console.ReadLine();
        }
    }
}