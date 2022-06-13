using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor
{
    abstract class Item
    {
        public abstract void Do(IItemVisitor visitor);
    }

    class Computer : Item
    {
        public override void Do(IItemVisitor visitor) 
        {
            visitor.Visit(this);
        }
    }

    class Bike : Item
    {
        public override void Do(IItemVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
