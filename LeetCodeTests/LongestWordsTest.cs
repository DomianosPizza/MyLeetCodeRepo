using LeetCode;
namespace LeetCodeTests
{
    public class Tests
    {
        LengthOfLastWord word_search = new LengthOfLastWord();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testing_Hello_World_Gets_Result_of_Five()
        {
            string phrase = "Hello World";

            Assert.That(word_search.LengthoWord(phrase), Is.EqualTo(5));
        }

        [Test]
        public void Testing_Weirdly_Spaced_String_Gets_Result_Of_Four()
        {
            string phrase = "   fly me   to   the moon  ";
            Assert.That(word_search.LengthoWord(phrase), Is.EqualTo(4));
        }

        [Test]
        public void Testing_Longer_String_Gets_Result_Of_Six()
        {
            string phrase = "luffy is still joyboy";
            Assert.That(word_search.LengthoWord(phrase), Is.EqualTo(6));
        }
    }
}