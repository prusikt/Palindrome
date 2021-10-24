using System.Runtime.CompilerServices;
using PalindromeChallangeTomaszPrusik.Palindrome;
using PalindromeChallangeTomaszPrusik.Screen;

[assembly: InternalsVisibleTo("PalindromeTests")]
namespace PalindromeChallangeTomaszPrusik
{
	public class Program
	{
        static void Main( )
        {
            ScreenDisplay.Open();
            new Application(new PalindromeService()).Run();
        }
    }
}
