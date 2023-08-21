using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {

        [Test]
        public void EmptyString()
        {
            string s = "";
            Assert.AreEqual(Text.Str.IsPalindrome(s), true);
        }
        [Test]
        public void NotEmptyString()
        {
            string s = "level";
            Assert.AreEqual(Text.Str.IsPalindrome(s), true);
        }
        [Test]
        public void NotAPalindrome()
        {
            string s = "empty";
            Assert.AreEqual(Text.Str.IsPalindrome(s), false);
        }
    }
}