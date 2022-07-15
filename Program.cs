namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Behavioral.Visitor.Example example = new Behavioral.Visitor.Example();

            example.Example1();
            example.Example2();
            example.Example3();

        }
    }
}