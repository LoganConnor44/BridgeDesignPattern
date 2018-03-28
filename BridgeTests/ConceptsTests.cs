using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeDesignPattern.Abstractions;
using BridgeDesignPattern.Implementations;

namespace BridgeTests
{
    [TestClass]
    public class ConceptsTests
    {
        [TestMethod]
        public void TestOperation()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementationOne();
            Assert.AreNotEqual(ab.Operation(), "asdf");

            // Change implemention and call
            ab.Implementor = new ConcreteImplementationTwo();
            Assert.AreEqual(ab.Operation(), "ConcreteImplementationTwo Operation");
        }
    }
}