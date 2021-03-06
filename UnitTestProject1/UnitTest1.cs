using CoffeMakerDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrderACoffee_Should_return_Received_Message()
        {
            //Arrange
            StarbuckStor store = new StarbuckStor(new FakeStarbucksStore());
            //Act
            string result = store.OrderCoffee(2, 4);

            //Assert
            Assert.AreEqual("Your Order is received.", result);
        }

        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingStub()
        {
            StarbuckStor store = new StarbuckStor(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your order is received.", result);
        }

        //Moq MOCK

        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingMock()
        {
            var service = new Mock<IMakeACoffee>();
            service.Setup(x => x.CheckIngredientAvailability()).Returns(true);
            //service.Setup(x => x.CoffeeMaking(It.Is<int>,It.Is<int>)).Returns("Your oredr is received");
            //service.Setup(x => x.CheckIngredientAvailability()).Returns(true);
            StarbuckStor store = new StarbuckStor(new Starbucks());
            var result = store.OrderCoffee(2, 4);
            //Assert.AreEqual("Your Order is received", result);

        }



    }

}
