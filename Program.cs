namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visitor.Example example = new Visitor.Example();

            example.Example1();
            example.Example2();
            example.Example3();

        }
    }
}