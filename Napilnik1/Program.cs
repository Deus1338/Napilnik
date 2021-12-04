using System;
using System.Threading.Tasks;

namespace Napilnik1
{
    public static class Program
    {
        private static async Task Main(string[] args)
        {
            var player = new Player(100);
            var botWeapon = new Weapon(10, 100);
            var bot = new Bot(botWeapon);

            for (int i = 0; i < 10; i++)
            {
                bot.OnSeeTarget(player);
                await Task.Delay(100);
            }
        }
    }
}