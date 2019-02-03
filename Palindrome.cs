using System;

namespace Palindrome
{
    public sealed class Palindrome
    {
        /// <summary>
        /// Method checks if input string is a palindrome.
        /// Altered method to accept string input instead of char Array.
        /// Functionally they are equivalent.
        /// Modified to execute without duplicating strings using 
        /// minimum space complexity.
        /// </summary>
        /// <param name="arr">A character array.</param>
        /// <returns>Boolean result</returns>
        public bool IsPalindrome(string strInput)
        {
            // Defines empty input as NOT a palindrome.
            if (String.IsNullOrEmpty(strInput))
            {
                throw new ArgumentNullException(nameof(strInput));
            }

            int left = 0;
            int right = strInput.Length - 1;

            while (left < right)
            {
                // Skip over spaces to allow for sentences.
                if (strInput[left] == ' ')
                {
                    left++;
                }
                if (strInput[right] == ' ')
                {
                    right--;
                }
                // Call case insensitive method.
                if (AreEqualCaseInsensitive(strInput[left], strInput[right]))
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Compares two characters for case insensitive equality in-place.
        /// </summary>
        /// <param name="left">left char</param>
        /// <param name="right">right char</param>
        /// <returns>
        /// Returns bool result of match to calling method.
        /// </returns>
        private static bool AreEqualCaseInsensitive(char left, char right)
        {
            if (left == right)
            {
                return true;
            }
            if (char.IsLetter(left) && char.IsLetter(right))
            {
                return char.ToLower(left) == char.ToLower(right);
            }
            return false;
        }
    }
}
