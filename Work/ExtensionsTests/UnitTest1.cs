using Extensions;

namespace ExtensionsTests
{
    public class StringExtensionTests
    {
        [Theory]
        [InlineData("Hello World", "Ellohay Orldway")]
        public void ToPigLatin_ReturnsCorrectString(string m, string expected)
        {
            string actual = m.ToPigLatin();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("This is a test string", 5)]
        [InlineData("Testing with, punctuation. things", 4)]
        public void WordCount_ReturnsCorrectInt(string m, int expected)
        {
            int actual = m.WordCount();
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("It shouldn't care about punctuation!", "!noitautcnup tuoba erac t'ndluohs tI")]
        public void ReverseWord_ReturnsCorrectString(string m, string expected)
        {
            string actual = m.ReverseWord();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("These are some words", "words some are These")]
        public void ReverseWordOrder_ReturnsCorrectString(string m, string expected)
        {
            string actual = m.ReverseWordOrder();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Too hot to hoot", true)]
        [InlineData("Me, myself, and I", false)]
        public void IsPalindrome_ReturnsCorrectBool(string m, bool expected)
        {
            bool actual = m.IsPalindrome();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("HelLo All YoU BeaUTIFUL People", "hELlO aLL yOu bEAutiful pEOPLE")]
        public void FlipCasing_ReturnsCorrectString(string m, string expected)
        {
            string actual = m.FlipCasing();
            Assert.Equal(expected, actual);
        }
    }
}
