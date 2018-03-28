namespace BridgeDesignPattern
{
    public class Abstraction
    {
        protected Implementor _implementor;

        public Implementor Implementor { set => _implementor = value; }

        public virtual void Operation()
        {
            _implementor.Operation();
        }
    }
}