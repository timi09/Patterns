namespace Patterns.Behavioral.Visitor
{
    class Example
    {
        public void Example1() 
        {
            Item item = new Computer();

            IItemVisitor visitor = new DoEnjoy();

            item.Do(visitor);
        }

        public void Example2()
        {
            Item item = new Computer();

            List<IItemVisitor> visitors = new List<IItemVisitor>();

            visitors.Add(new DoEnjoy());
            visitors.Add(new DoWork());

            foreach (IItemVisitor visitor in visitors)
            {
                item.Do(visitor);
            }
        }

        public void Example3()
        {
            IItemVisitor visitor = new DoWork();

            List<Item> items = new List<Item>();

            items.Add(new Computer());
            items.Add(new Bike());

            foreach (Item item in items)
            {
                item.Do(visitor);
            }
        }
    }
}
