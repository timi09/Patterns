namespace Patterns.Creational.Factory_Method
{
    interface IVehicleFactory
    {
        public IDrivable Create();
    }

    class CarFactory : IVehicleFactory
    {
        public IDrivable Create()
        {
            return new Car();
        }
    }

    class MotorbikeFactory : IVehicleFactory
    {
        public IDrivable Create()
        {
            return new Motorbike();
        }
    }
}
