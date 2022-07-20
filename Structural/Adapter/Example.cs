namespace Patterns.Structural.Adapter
{
    class Example
    {
        public void Example1() 
        {
            Zoo zoo = new Zoo();

            Duck duck = new Duck();

            Bear bear = new Bear();

            zoo.SeeWalkingAnimal(bear);
            zoo.SeeFlyingAnimal(duck);
            
            BearAdapter flyingBear = new BearAdapter(bear);

            zoo.SeeFlyingAnimal(flyingBear);
        }

        private class Zoo 
        {
            public void SeeWalkingAnimal(IWalking animal) 
            {
                animal.Walk();
            }

            public void SeeFlyingAnimal(IFlying animal) 
            {
                animal.Fly();
            }
        }
    }
}
