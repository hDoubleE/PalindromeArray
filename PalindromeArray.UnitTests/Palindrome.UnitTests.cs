using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeArray.UnitTests
{
    [TestClass]
    public class PalindromeUnitTests
    {
        [TestMethod]
        public void Check_Longest_Palindrome_In_Dictionary()
        {
            // Arrange
            Palindrome check = new Palindrome();
            // The longest palindromic word in the Oxford English Dictionary is "tattarrattat", 
            // coined by James Joyce in Ulysses (1922) for a knock on the door.
            char[] arrToCheck = check.PalindromeHelper("tattarrattat");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Odd_Palindrome_One()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("radar");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Odd_Palindrome_Two()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("catytac");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Even_Palindrome_One()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("Otto");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Even_Palindrome_Two()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("Hannah");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Non_Palindrome_Outer_Chars_Do_Not_Match()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("aooooooob");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(false, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Palindrome_Inner_Chars_Do_Not_Match()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("oooabooo");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(false, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Sentence_Palindrome()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("Murder for a jar of red rum");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(true, boolResultOfPalindromeCheck);
        }
        [TestMethod]
        public void Check_Sentence_Non_Palindrome()
        {
            // Arrange
            Palindrome check = new Palindrome();
            char[] arrToCheck = check.PalindromeHelper("This.. is345 A senTence...");
            // Act
            bool boolResultOfPalindromeCheck = check.IsArrayPalindrome(arrToCheck);
            // Assert
            Assert.AreEqual(false, boolResultOfPalindromeCheck);
        }
    }
}
