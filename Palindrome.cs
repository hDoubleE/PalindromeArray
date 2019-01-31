using System;

namespace PalindromeArray
{
    public class Palindrome
    {
        public bool IsArrayPalindrome(char[] arr)
        {
            if (arr.Length == 0)
            {
                return false;
            }

            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                if (arr[start] == arr[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public char[] PalindromeHelper(string s)
        {
            // Tests failed on Names and Sentences due to white space.
            // Had to use String.Replace and ToLower methods in helper
            // to fix input...is this right?
            // Is pre-gaming the input cheating...or does the method need work?
            string fixString = s.ToLower().Replace(" ", String.Empty);
            char[] charArray = fixString.ToCharArray();
            return charArray;
        }
    }
}
