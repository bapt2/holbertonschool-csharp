using NUnit.Framework;
using System.Collections.Generic;
namespace MyMath.Tests
{
    public class Tests
    {

        [Test]
        public void FindMax()
        {
            List<int> list = new List<int>() {3, 15, 50, 2, 7};
            Assert.AreEqual(MyMath.operation.Max(list), 50);
            List<int> list = new List<int>() {9, 2, 7};
            Assert.AreEqual(MyMath.operation.Max(list), 9);
            List<int> list = new List<int>() {3, 7, -5, 15};
            Assert.AreEqual(MyMath.operation.Max(list), 15);
        }
        public void FindMaxEmpty()
        {
            List<int> list = new List<int>() {};
            Assert.AreEqual(MyMath.operation.Max(list), 0);
        }
    }
}