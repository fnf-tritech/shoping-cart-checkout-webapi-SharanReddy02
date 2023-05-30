using WebApplication5;
using Xunit;

namespace Checkout_Tests
{
    public class UnitTest1
    {
        private readonly Checkout _checkout;
        public UnitTest1()
        {
            _checkout = new Checkout();
        }
        [Fact]
        public void Test1()
        {
            string skus = "";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(0, totalPrice);
        }
        [Fact]
        public void Test2()
        {
            string skus = "A";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(50, totalPrice);
        }
        [Fact]
        public void Test3()
        {
            string skus = "ABABA";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(175, totalPrice);
        }
        [Fact]
        public void Test4()
        {
            string skus = "AB";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(80, totalPrice);
        }
        [Fact]
        public void Test5()
        {
            string skus = "AAA";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(130, totalPrice);
        }
        [Fact]
        public void Test6()
        {
            string skus = "BB";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(45, totalPrice);
        }
        [Fact]
        public void Test7()
        {
            string skus = "CD";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(35, totalPrice);
        }
        [Fact]
        public void Test8()
        {
            string skus = "ABCD";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(115, totalPrice);
        }
        [Fact]
        public void Test9()
        {
            string skus = "ABD";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(95, totalPrice);
        }
        [Fact]
        public void Test10()
        {
            string skus = "BCABDAA";
            int totalPrice = _checkout.CalculateTotalCost(skus);
            Assert.Equal(210, totalPrice);
        }
    }
}