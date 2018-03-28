using System;

namespace BridgeDesignPattern.Implementations
{
    class ConcreteImplementationTwo : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementationTwo Operation");
        }
    }
}