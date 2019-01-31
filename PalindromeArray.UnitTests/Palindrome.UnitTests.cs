using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Added a test for Empty Input.
// Created branch 'review' for PR sharing.


namespace PalindromeArray.UnitTests
{
    [TestClass]
    public class PalindromeUnitTests
    {
        [TestMethod]
        public void Check_Empty_Input()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(false, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Longest_Palindrome_In_Dictionary()
        {
            Palindrome check = new Palindrome();
            // The longest palindromic word in the Oxford English Dictionary is "tattarrattat", 
            // coined by James Joyce in Ulysses (1922) for a knock on the door.
            char[] arrToCheck = check.PalindromeHelper("tattarrattat");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Odd_Palindrome_One()
        {
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("radar");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Odd_Palindrome_Two()
        {
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("catytac");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Even_Palindrome_One()
        {
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("Otto");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Even_Palindrome_Two()
        {
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("Hannah");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Non_Palindrome_Outer_Chars_Do_Not_Match()
        {
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("aooooooob");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(false, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Palindrome_Inner_Chars_Do_Not_Match()
        {
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("oooabooo");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(false, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Sentence_Palindrome()
        {
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("Murder for a jar of red rum");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Sentence_Non_Palindrome()
        {
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("This.. is345 A senTence...");

            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);

            Assert.AreEqual(false, boolResultOfPalindromeCheck);
        }
    }
}
