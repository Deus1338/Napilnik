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

        private bool CanFire => bullets > 0;

        public void TryFire(IDamagable target)
        {
            if (!CanFire)
                throw new InvalidOperationException(nameof(bullets));
            if(target.IsDead)
                throw new InvalidOperationException(nameof(Player));

            Fire(target);
        }

        private void Fire(IDamagable target)
        {
            bullets = Math.Max(0, bullets - 1);
            
            target.TakeDamage(damage);
        }
    }
}