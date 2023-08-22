using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void EmptyString()
        {
            string s = "";
            Assert.AreEqual(Text.Str.CamelCase(s), 0);
        }
        [Test]
        public void NotEmptyString()
        {
            string s = "hello I D'ont Know What To Write";
            Assert.AreEqual(Text.Str.CamelCase(s), 7);
            s = "hello";
            Assert.AreEqual(Text.Str.CamelCase(s), 1);
        }
    }
}