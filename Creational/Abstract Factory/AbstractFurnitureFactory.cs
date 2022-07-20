namespace Patterns.Creational.Abstract_Factory
{
    abstract class AbstractFurnitureFactory
    {
        public abstract Table CreateTable();
        public abstract Chair CreateChair();
    }

    class WoodFurnitureFactory : AbstractFurnitureFactory
    {
        public override Table CreateTable() 
        {
            return new WoodTable();
        }

        public override Chair CreateChair()
        {
            return new WoodChair();
        }
    }

    class PlasticFurnitureFactory : AbstractFurnitureFactory
    {
        public override Table CreateTable()
        {
            return new PlasticTable();
        }

        public override Chair CreateChair()
        {
            return new PlasticChair();
        }
    }
}
