namespace Patterns.Behavioral.Visitor
{
    interface IItemVisitor
    {
        void Visit(Item item);
        void Visit(Computer item);
        void Visit(Bike Item);
    }

    class DoEnjoy : IItemVisitor
    {
        public void Visit(Item item) 
        {
            Console.WriteLine("Do something enjoy");
        }

        public void Visit(Computer item)
        {
            Console.WriteLine("Play computer games");
        }

        public void Visit(Bike Item)
        {
            Console.WriteLine("Ride a bike");
        }
    }

    class DoWork : IItemVisitor
    {
        public void Visit(Item item)
        {
            Console.WriteLine("Do something work");
        }

        public void Visit(Computer item)
        {
            Console.WriteLine("Write code");
        }

        public void Visit(Bike Item)
        {
            Console.WriteLine("Fix a bike");
        }
    }
}
