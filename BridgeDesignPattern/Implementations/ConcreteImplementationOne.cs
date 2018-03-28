using System;

namespace BridgeDesignPattern.Implementations
{
    class ConcreteImplementationOne : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementationOne Operation");
        }
    }
}