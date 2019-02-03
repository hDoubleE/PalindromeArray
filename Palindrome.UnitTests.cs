using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.UnitTests
{
    [TestClass]
    public sealed class PalindromeUnitTests
    {
        /* 
        *  Test class contains 3 helper methods.
        *  Passing 6/6 test cases.
        */

        /// <summary>
        /// Generates a random string of upper and lower case letters including ' '.
        /// Passes result string to RandomPalindromeGenerator.
        /// </summary>
        /// <returns>A string containing less than 1000 characters.</returns>
        private static string RandomString()
        {
            Random rand = new Random();
            int length = rand.Next(0, 999);

            char[] arr = new char[length];
            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = allowedChars[rand.Next(0, allowedChars.Length)];
            }
            return new string(arr);
        }

        /// <summary>
        /// Calls RandomString and creates Palindrome double the length of string.
        /// Loops beginning to end adding each char to StringBuilder object.
        /// Then loops back to front adding to StringBuiilder in reverse.
        /// </summary>
        /// <returns>String that is a palindrome less tha 2000 characters.</returns>
        private static string RandomPalindromeGenerator()
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();

            string randomString = RandomString();

            // Random string has even character count.
            // Generates even numbered palindrome.
            if (randomString.Length % 2 == 0)
            {
                for (int i = 0; i < randomString.Length; i++)
                {
                    sb.Append(randomString[i]);
                }
                for (int i = randomString.Length - 1; i >= 0; i--)
                {
                    sb.Append(randomString[i]);
                }
            }
            // String has odd character count. 
            // Make odd palidrome with a central "pivot" character.
            else
            {
                for (int i = 0; i < randomString.Length; i++)
                {
                    sb.Append(randomString[i]);
                }
                // Skip last character on reverse leaving singleton as pivot.
                for (int i = randomString.Length - 2; i >= 0; i--)
                {
                    sb.Append(randomString[i]);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Auto generates unit test cases to avoid code repetition.
        /// </summary>
        /// <param name="input">String to test for being palindrome.</param>
        /// <param name="expectedOutput">Expected bool result of palindrome test.</param>
        private static void RunIsPalindromeTest(string input, bool expectedOutput)
        {
            //Arrange
            Palindrome unit = new Palindrome();
            // Act
            bool actualResult = unit.IsPalindrome(input);
            // Asert 
            Assert.AreEqual(expectedOutput, actualResult, $"{nameof(unit.IsPalindrome)}(\"{input}\")");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Null_Input()
        {
            // Arrange
            Palindrome unit = new Palindrome();
            // Act
            unit.IsPalindrome(null);
            // Assert: Expects Exception.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Empty_Input()
        {
            // Arrange
            Palindrome unit = new Palindrome();
            // Act
            unit.IsPalindrome(String.Empty);
            // Assert: Expects Exception.
        }

        [TestMethod]
        public void Test_Randomly_Generated_Palindrome()
        {
            RunIsPalindromeTest(RandomPalindromeGenerator(), true);
        }

        [TestMethod]
        public void Test_Case_Insensitive()
        {
            RunIsPalindromeTest("OtTo", true);
        }

        [TestMethod]
        public void Test_Sentence_With_Random_Caps()
        {
            RunIsPalindromeTest("Murder for a JAR of reD rum", true);
        }

        [TestMethod]
        public void Test_False_Output()
        {
            RunIsPalindromeTest("NotAPal", false);
        }
    }
}