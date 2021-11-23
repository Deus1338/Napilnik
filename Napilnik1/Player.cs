using System;

namespace Napilnik1
{
    class Player
    {
        private int health;

        public Player(int health)
        {
            if (health <= 0)
                throw new ArgumentOutOfRangeException(nameof(health));

            this.health = health;
        }

        public bool IsDead => health == 0;

        public void TryTakeDamage(int damage)
        {
            if (IsDead)
                throw new InvalidOperationException(nameof(IsDead));

            if (damage <= 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            TakeDamage(damage);
        }

        private void TakeDamage(int damage)
        {
            health = Math.Max(0, health - damage);
        }
    }
}