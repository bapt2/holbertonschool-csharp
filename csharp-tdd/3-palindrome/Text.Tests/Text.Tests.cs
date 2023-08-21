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
        [Test]
        public void Spaces()
        {
            string s = "lev el ";
            Assert.AreEqual(Text.Str.IsPalindrome(s), true);
        }
        [Test]
        public void Punctuation()
        {
            string s = "A man, a plan, a canal: Panama.";
            Assert.AreEqual(Text.Str.IsPalindrome(s), true);
        }
        [Test]
        public void UpperAndLower()
        {
            string s = "Level";
            Assert.AreEqual(Text.Str.IsPalindrome(s), true);
        }
    }
}