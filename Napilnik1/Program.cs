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

            warehouse.DisplayContentInfo();

            Cart cart = shop.CreateCart();

            cart.Add(cup, 4);
            cart.Add(plate, 1);

            cart.DisplayContentInfo();

            warehouse.DisplayContentInfo();

            Console.WriteLine(cart.Order().Paylink);
            Console.ReadLine();
        }
    }
}