using System.Collections.Generic;
using System.Linq;
using System.Threading;
using PalindromeChallangeTomaszPrusik.Palindrome;
using static System.Console;

namespace PalindromeChallangeTomaszPrusik.Screen
{
    public static class ScreenDisplay
    {
        private static string signature = "This is palindrome challange - Tomasz Prusik";

        public static void Open()
        {
            Title = string.Empty;

            for (int i = 1; i < 50; i++)
            {
                SetWindowSize(i+100, i);
                Thread.Sleep(50);
            }

            var progressBar = signature;
            var title = string.Empty;

            foreach (var letter in progressBar)
            {
                title += letter;
                Title = title;
                Thread.Sleep(100);
            }
        }

        public static void DisplayResults(IReadOnlyCollection<Palindrome.Palindrome> listOfPalindromes)
        {
            if (listOfPalindromes.Any())
            {
                foreach (var uniquePalindrome in listOfPalindromes)
                {
                    WriteLine($"Text: {uniquePalindrome.Text}, Index:  {uniquePalindrome.Index}, Length: {uniquePalindrome.Length}");
                }
            }
            else
            {
                WriteLine("");
                WriteLine("No palindrome found");
                WriteLine("");
            }
        }

        public static string GetInputString()
        {
            string input = string.Empty;

            while (!input.IsValidInputString())
            {
                WriteLine("Lets find the 3 longest unique palindromes in a supplied string.");
                WriteLine("Submit text...");

                input = ReadLine();
                if (!input.IsValidInputString())
                {
                    WriteLine("Incorrect input string, try again");
                    input = string.Empty;
                }
            }

            return input;
        }

        public static bool Repeat()
        {
            while (true)
            {
                WriteLine("Would you like to try again? Y/N");
                WriteLine("Alt+ F4 to close");
                var line = ReadLine();
                if (line != null)
                {
                    switch (line.ToLower())
                    {
                        case string yes when yes == "yes" || yes == "y":
                            Clear();
                            return true;
                        case string no when no == "no" || no == "n":
                            return false;
                    }
                }
            }

        }

        public static void End()
        {
            WriteLine("Thank you for playing.");
            Thread.Sleep(200);
        }
    }
}
