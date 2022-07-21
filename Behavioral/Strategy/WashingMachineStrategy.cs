namespace Patterns.Behavioral.Strategy
{
    interface IWashingStrategy
    {
        public void WashingAlgorithm();
    }

    class DelicateWashing : IWashingStrategy
    {
        public void WashingAlgorithm()
        {
            Console.WriteLine("Start delicate washing. 30c, 800 rpm");
        }
    }

    class UltraWashing : IWashingStrategy
    {
        public void WashingAlgorithm()
        {
            Console.WriteLine("Start ultra washing. 60c, 1600 rpm");
        }
    }

    class WashingMachine
    {
        public IWashingStrategy WashingStrategy { get; set; }

        public WashingMachine(IWashingStrategy washingStrategy)
        {
            WashingStrategy = washingStrategy;
        }   

        public void StartWashing()
        {
            WashingStrategy.WashingAlgorithm();
        }
    }


}
