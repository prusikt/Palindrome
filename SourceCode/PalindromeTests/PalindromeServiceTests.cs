using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChallangeTomaszPrusik.Palindrome;

namespace PalindromeTests
{
    [TestClass]
    public class PalindromeServiceTests
    {
        private readonly PalindromeService _palindromeService;

        public PalindromeServiceTests()
        {
            _palindromeService = new PalindromeService();
        }

        [DataTestMethod]
        [DataRow("sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop", 3)]
        [DataRow("sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop", 1)]
        public void ProcessText_Returns_Number_of_unique_palindromes(string text, int outputSize)
        {
            var result = _palindromeService.ProcessText(text, outputSize);
            Assert.IsTrue(result.Count() == outputSize);
        }

        [TestMethod]
        public void GetUniquePalindromes_PassTwoTheSame_ReturnOnlyOne()
        {
            IReadOnlyCollection<Palindrome> palindromes = new List<Palindrome>(){
                new Palindrome
                {
                    Index = 1,Length = 4,Text = "abba"
                },
                new Palindrome
                {
                    Index = 1,Length = 4,Text = "abba"
                }
            };

            var result = _palindromeService.GetUniquePalindromes(palindromes,2);
            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void GetAllPalindromes_ReturnAllPalindromes()
        {
            var all = _palindromeService.GetAllPalindromes("mnnmzpop");
            
            Assert.IsTrue(all.Count == 3);
        }
    }
}
