using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Factory_Method
{
    interface IDrivable
    {
        public void Drive();
    }

    class Car : IDrivable
    {
        public void Drive() 
        {
            Console.WriteLine("Drive car");
        }
    }

    class Motorbike : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Drive motorbike");
        }
    }

}
