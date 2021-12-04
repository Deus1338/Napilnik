using System;

namespace Napilnik1
{
    class Bot
    {
        private readonly Weapon weapon;

        public Bot(Weapon weapon)
        {
            if(weapon == null)
                throw new ArgumentNullException(nameof(weapon));

            this.weapon = weapon;
        }

        public void OnSeeTarget(IDamagable target)
        {
                weapon.TryFire(target);
        }
    }
}