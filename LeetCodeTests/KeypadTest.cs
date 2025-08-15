using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    public class KeypadTest
    {
        LetterCombos find_combos = new LetterCombos();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void testing_singular_number()
        {
            string numbers = "2";
            List<string> answer = new List<string> {"a","b","c" };
            Console.WriteLine(find_combos.LetterCombinations(numbers));
            Console.WriteLine(answer);
        }

    }
}
