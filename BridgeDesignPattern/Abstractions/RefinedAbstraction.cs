namespace BridgeDesignPattern.Abstractions
{
    public class RefinedAbstraction : Abstraction
    {
        public override string Operation()
        {
            return _implementor.Operation();
        }
    }
}