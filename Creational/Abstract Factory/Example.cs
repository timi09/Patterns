namespace Patterns.Creational.Abstract_Factory
{
    class Example
    {
        public void Example1()
        {
            Room room1 = new Room(new WoodFurnitureFactory());
            room1.Show();

            Room room2 = new Room(new PlasticFurnitureFactory());
            room2.Show();
        }

        private class Room 
        {
            private Table _table;
            private Chair _chair;

            public Room(AbstractFurnitureFactory furnitureFactory)
            {
                _table = furnitureFactory.CreateTable();
                _chair = furnitureFactory.CreateChair();
            }

            public void Show()
            {
                Console.WriteLine($"Room has: {_table.getTableName()}, {_chair.getChairName()}");
            }
        }
    }
}
