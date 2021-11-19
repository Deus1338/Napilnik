using System;

namespace Napilnik1
{
    class Weapon
    {
        private int damage;
        private int bullets;
        
        public Weapon(int damage, int bullets)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(bullets));

            this.damage = damage;
            this.bullets = bullets;
        }

        private bool CanShoot => bullets > 0;

        public void TryFire(Player player)
        {
            if (!CanShoot)
                throw new InvalidOperationException(nameof(bullets));

            Fire(player);
        }

        private void Fire(Player player)
        {
            bullets = Math.Max(0, bullets - 1);
            Console.WriteLine(bullets);
            player.TryTakeDamage(damage);
            
        }
    }
}