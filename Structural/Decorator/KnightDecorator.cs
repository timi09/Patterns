namespace Patterns.Structural.Decorator
{
    class KnightDecorator : Human
    {
        protected Human _human;
        public override int Health { get { return _human.Health; } }
        public int Armor { get; private set; }
        public int Damage { get; private set; }

        public KnightDecorator(Human human, int armor, int damage)
        {
            _human = human;
            Armor = armor;
            Damage = damage;
        }

        public override void TakeDamage(int damage)
        {
            if (damage > Armor)
                _human.TakeDamage(damage - Armor);
        }

        public void Attack(Human human) 
        {
            human.TakeDamage(Damage);
        }
    }
}
