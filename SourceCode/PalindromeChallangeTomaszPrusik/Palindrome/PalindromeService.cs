using System.Collections.Generic;
using System.Linq;

namespace PalindromeChallangeTomaszPrusik.Palindrome
{ 
    public class PalindromeService 
    {
        public IReadOnlyCollection<Palindrome> ProcessText(string input, int outputSize)
        {
            var palindromes = GetAllPalindromes(input);
            return  GetUniquePalindromes(palindromes, outputSize);
        }

        internal IReadOnlyCollection<Palindrome> GetUniquePalindromes(IReadOnlyCollection<Palindrome> listOfPalindromes, int outputSize)
        {
            var uniquePalindromes = new List<Palindrome>();
            
            foreach (var palindrome in listOfPalindromes)
            {
                if (!uniquePalindromes.Contains(uniquePalindromes.SingleOrDefault(x => x.Length == palindrome.Length)))
                {
                    uniquePalindromes.Add(palindrome);
                }
            }
            return uniquePalindromes
                .OrderByDescending(x => x.Length)
                .Take(outputSize).ToList();
        }

        internal IReadOnlyCollection<Palindrome> GetAllPalindromes(string input)
        {
            var charArray = input.ToArray();
            var listOfPalindromes = new List<Palindrome>();

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = i + 1; j < charArray.Length; j++)
                {
                    if (input.IsPalindrome(i, j - 1 + 1, out var palindrome))
                    {
                        listOfPalindromes.Add(palindrome);
                    }
                }
            }
            return listOfPalindromes;
        }
    }
}
