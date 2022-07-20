namespace Patterns.Structural.Adapter
{
    interface IFlying
    {
        public void Fly();
    }

    class Duck : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("- See, duck is flying.");
        }
    }

    interface IWalking
    {
        public void Walk();
    }

    class Bear : IWalking
    {
        public void Walk() 
        {
            Console.WriteLine("- See, bear is walking.");
        }
    }

    class BearAdapter : IFlying
    {
        private Bear _bear;

        public BearAdapter(Bear bear)
        {
            _bear = bear;
        }

        public void Fly()
        {
            _bear.Walk();
            Console.WriteLine("- Oh god, flying bear.\n- He is adapted");
        }
    }
}
