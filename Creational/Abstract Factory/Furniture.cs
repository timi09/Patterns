namespace Patterns.Creational.Abstract_Factory
{
    abstract class Table
    {
        public abstract string getTableName();
    }

    abstract class Chair
    {
        public abstract string getChairName();
    }

    class WoodTable : Table 
    {
        public override string getTableName()
        {
            return "wood table";
        }
    }

    class PlasticTable : Table
    {
        public override string getTableName()
        {
            return "plastic table";
        }
    }

    class WoodChair : Chair
    {
        public override string getChairName()
        {
            return "wood chair";
        }
    }

    class PlasticChair : Chair
    {
        public override string getChairName()
        {
            return "plastic chair";
        }
    }
}
