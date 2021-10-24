using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChallangeTomaszPrusik.Palindrome;

namespace PalindromeTests
{
    [TestClass]
    public class PalindromeLogicTests
    {
        [DataTestMethod]
        [DataRow("abba", true)]
        [DataRow("12", false)]
        public void IsPalindrome_CheckIfStringIsPalindrome(string text, bool expectedResult)
        {
            var result = PalindromeLogic.ValidateText(text);

            Assert.IsTrue(result == expectedResult);
        }

        [DataTestMethod]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("0", true)]
        public void IsValidInputString_CheckIfStringIsNotEmpty(string text, bool expectedResult)
        {
            var result = text.IsValidInputString();

            Assert.IsTrue(result == expectedResult);
        }
    }
}
