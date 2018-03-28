namespace BridgeDesignPattern.Abstractions
{
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            _implementor.Operation();
        }
    }
}