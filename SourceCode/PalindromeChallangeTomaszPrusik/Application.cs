using PalindromeChallangeTomaszPrusik.Palindrome;
using PalindromeChallangeTomaszPrusik.Screen;

namespace PalindromeChallangeTomaszPrusik
{
    public class Application
    {
        private readonly PalindromeService _palindromeService;
        private bool _runApp;

        public Application(PalindromeService palindromeService)
        {
            _palindromeService = palindromeService;
            _runApp = true;
        }

        public void Run()
        {
            while (_runApp)
            {
                var inputString = ScreenDisplay.GetInputString();
                var result = _palindromeService.ProcessText(inputString, 3);
                ScreenDisplay.DisplayResults(result);
                _runApp = ScreenDisplay.Repeat();
            }

            ScreenDisplay.End();
        }
    }
}
