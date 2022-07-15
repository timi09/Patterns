namespace Patterns.Behavioral.Observer
{
    interface INotifier
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObservers();
    }

    class TemperatureSensor : INotifier
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        public int Temperature { get; private set; }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
                observer.Update(Temperature);
        }

        public void setTemperature(int state) 
        {
            Temperature = state;
            NotifyObservers();
        }
    }
}
