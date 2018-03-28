using BridgeDesignPattern.Implementations;

namespace BridgeDesignPattern.Abstractions
{
    public class Abstraction
    {
        protected Implementor _implementor;

        public Implementor Implementor { set => _implementor = value; }

        public virtual string Operation()
        {
            return _implementor.Operation();
        }
    }
}