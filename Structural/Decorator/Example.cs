namespace Patterns.Structural.Decorator
{
    class Example
    {
        public void Example1()
        {
            Villager villager = new Villager(100);

            villager.TakeDamage(20);

            Console.WriteLine($"Villager has {villager.Health} HP");

            KnightDecorator knight = new KnightDecorator(villager, 10, 15);

            knight.TakeDamage(20);

            Console.WriteLine($"Knight has {knight.Health} HP");
        }

        public void Example2()
        {
            KnightDecorator enemyKnight = new KnightDecorator(new Villager(100), 10, 20);

            Villager friendVillager = new Villager(100);

            enemyKnight.Attack(friendVillager);

            Console.WriteLine($"Friend villager has {friendVillager.Health} HP");

            KnightDecorator friendKnight = new KnightDecorator(friendVillager, 15, 25);

            friendKnight.Attack(enemyKnight);

            Console.WriteLine($"Enemy knight has {enemyKnight.Health} HP");
        }
    }
}
