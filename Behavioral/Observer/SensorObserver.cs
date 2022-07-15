namespace Patterns.Behavioral.Observer
{
    interface IObserver
    {
        void Update(int state);
    }

    class TemperatureMonitor : IObserver
    {
        public void Update(int state)
        {
            Console.WriteLine($"Temperature of sensor now: {state}");
        }
    }

    class TemperatureWarning : IObserver
    {
        public int MaxAllowedTemperature;
        public int MinAllowedTemperature;

        public TemperatureWarning(int maxAllowedTemperature, int minAllowedTemperature)
        {
            MaxAllowedTemperature = maxAllowedTemperature;
            MinAllowedTemperature = minAllowedTemperature;
        }

        public void Update(int state)
        {
            if (state > MaxAllowedTemperature)
                Console.WriteLine("Temperature is above the allowed!");

            if (state < MinAllowedTemperature)
                Console.WriteLine($"Temperature is below the allowed!");
        }
    }
}
