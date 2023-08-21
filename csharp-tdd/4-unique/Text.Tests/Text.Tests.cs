using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void UniqueCharacter()
        {
            string s = "test";
            Assert.AreEqual(Text.Str.UniqueChar(s), 1);
        }
        [Test]
        public void NonUniqueCharacter()
        {
            string s = "ttt";
            Assert.AreEqual(Text.Str.UniqueChar(s), -1);
        }
        [Test]
        public void EmptyString()
        {
            string s = "";
            Assert.AreEqual(Text.Str.UniqueChar(s), -1);
        }
    }
}