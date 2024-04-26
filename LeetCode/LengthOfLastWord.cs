using System.Collections.Specialized;

namespace LeetCode
{
    public class LengthOfLastWord
    {
        string[] word_array = new string[50];
        public LengthOfLastWord() { 

        }

        public int LengthoWord(string inputString)
        {
            int longest_word;
            word_array = inputString.Trim().Split(" ");
            string last_word;
            last_word = word_array[word_array.Length-1];
            Console.WriteLine(last_word);
            longest_word = last_word.Length;
            return longest_word;
        }
    }
}
