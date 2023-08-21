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
            Assert.AreEqual(MyMath.Operations.Max(list), 50);
            List<int> list1 = new List<int>() {9, 2, 7};
            Assert.AreEqual(MyMath.Operations.Max(list1), 9);
            List<int> list2 = new List<int>() {3, 7, 15};
            Assert.AreEqual(MyMath.Operations.Max(list2), 15);
        }
        public void FindMaxEmpty()
        {
            List<int> list = new List<int>() { };
            Assert.AreEqual(MyMath.Operations.Max(list), 0);
        }
        public void FindMaxNegativ()
        {
            List<int> list = new List<int>() {-1, -2, -3, -4, -5};
            Assert.AreEqual(MyMath.Operations.Max(list), -1);
        }
        
    }
}