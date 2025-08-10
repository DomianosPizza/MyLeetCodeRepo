using LeetCode;
namespace LeetCodeTests
{
    public class PalindromeTest
    {
        PalindromeNumber pal_search = new PalindromeNumber();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void testing_singular_number()
        {
            int number = 5;

            Assert.That(pal_search.IsPalindrome(number), Is.EqualTo(true));
        }

        [Test]
        public void Testing_Negative_Number()
        {
            int number = -601;
            Assert.That(pal_search.IsPalindrome(number), Is.EqualTo(false));
        }

        [Test]
        public void Testing_A_True_Result()
        {
            int number = 101;
            Assert.That(pal_search.IsPalindrome(number), Is.EqualTo(true));
        }
    }
}