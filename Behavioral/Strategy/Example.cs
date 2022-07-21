namespace Patterns.Behavioral.Strategy
{
    class Example
    {
        public void Example1()
        {
            WashingMachine washingMachine = new WashingMachine(new DelicateWashing());

            washingMachine.StartWashing();

            washingMachine.WashingStrategy = new UltraWashing();

            washingMachine.StartWashing();
        }
    }
}
