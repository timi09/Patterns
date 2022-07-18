namespace Patterns.Structural.Decorator
{
    abstract class Human
    {
        public virtual int Health { get; protected set; }
        public abstract void TakeDamage(int damage);
    }

    class Villager : Human
    {
        public Villager(int health)
        {
            Health = health;
        }

        public override void TakeDamage(int damage) 
        {
            Health -= damage;
        }
    }
}
