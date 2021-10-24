namespace PalindromeChallangeTomaszPrusik.Palindrome
{
    public static class PalindromeLogic
    {
        public static bool IsPalindrome(this string str, int index, int length, out Palindrome palindrome)
        {
            palindrome = null;
            var text = str.Substring(index, length - index + 1);

            if (!ValidateText(text))
            {
                return false;
            }

            palindrome = new Palindrome
            {
                Text = text,
                Index = index,
                Length = text.Length
            };

            return true;
        }

        public static bool IsValidInputString(this string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        public static bool ValidateText(string text)
        {
            if (text.Length > 0)
            {
                for (int i = 0; i < text.Length / 2; i++)
                {
                    if (!string.Equals(text.FrontPartString(i), text.EndPartString(i)))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        private static string FrontPartString(this string value, int index)
        {
            return value.Substring(index, 1);
        }

        private static string EndPartString(this string value, int index)
        {
            return value.Substring(value.Length - (index + 1), 1);
        }
    }
}