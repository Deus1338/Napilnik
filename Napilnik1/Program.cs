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

            ShowContentInfo(warehouse);

            Cart cart = shop.CreateCart();

            cart.Add(cup, 4);
            cart.Add(plate, 1);

            

            Console.WriteLine(cart.Order().Paylink);

            ShowContentInfo(cart);
            ShowContentInfo(warehouse);

            cart.Add(plate, 1);

            Console.ReadLine();
        }

        public static void ShowContentInfo(Storage storage)
        {
            
            Console.Write($"\n{ storage.GetType().Name.ToString()} content:\n");
            foreach (var pair in storage.Goods)
                Console.WriteLine($"{pair.Key.Name} : {pair.Value}");
        }
    }
}