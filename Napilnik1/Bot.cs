using System;

namespace Napilnik1
{
    class Bot
    {
        private Weapon weapon;

        public Bot(Weapon weapon)
        {
            if(weapon == null)
                throw new ArgumentNullException(nameof(weapon));

            this.weapon = weapon;
        }

        public void OnSeePlayer(Player player)
        {
            if (!player.IsDead)
                weapon.TryFire(player);
        }
    }
}