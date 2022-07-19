namespace Patterns.Creational.Factory_Method
{
    class Example
    {
        public void Example1()
        {
            List<IVehicleFactory> factories = new List<IVehicleFactory>()
            {
                new CarFactory(),
                new MotorbikeFactory()
            };

            foreach (var factory in factories)
            {
                var vehicle = factory.Create();
                vehicle.Drive();
            }
        }

        public void Example2()
        {
            CarFactory carFactory = new CarFactory();

            ContextMethod(carFactory);

            MotorbikeFactory motorbikeFactory = new MotorbikeFactory();

            ContextMethod(motorbikeFactory);
        }

        private void ContextMethod(IVehicleFactory factory) 
        {
            IDrivable vehicle = factory.Create();
            vehicle.Drive();
        }
    }
}
