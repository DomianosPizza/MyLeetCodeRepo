using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomanNumeralConversion
    {
        public int RomanToInt(string s)
        {
            int value = 0;
            Dictionary<char, int> num = new Dictionary<char, int>()
            {
                {'M', 1000 },
                {'D', 500 },
                {'C', 100 },
                {'L', 50 },
                {'X', 10 },
                {'V', 5 },
                {'I', 1 }
            };

            Console.WriteLine(s);

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && num[s[i]] < num[s[i + 1]])
                {
                    value -= num[s[i]];
                }
                else {
                    value += num[s[i]];
                }
            }
            return value;
        }
    }
}
