using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int a = Operations.Add(1, 9);
            Assert.AreEqual(a, 10);
        }
        
    }
}