using System;

namespace Napilnik1
{
    class Player : IDamagable
    {
        private int health;

        public Player(int health)
        {
            if (health <= 0)
                throw new ArgumentOutOfRangeException(nameof(health));

            this.health = health;
        }

        public bool IsDead => health == 0;

        public void TakeDamage(int damage)
        {
            if (damage <= 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            health = Math.Max(0, health - damage);
        }
    }

    public interface IDamagable
    {
        bool IsDead { get; }
        void TakeDamage(int damage);
    }
}