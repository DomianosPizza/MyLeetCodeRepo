using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LetterCombos
    {
        public IList<string> LetterCombinations(string digits) {
            //when given a string of numbers
            //return all possible keypad combinations of letters that it could be
            //Ex.) "23" is {"ad", "ae", "af", "bd", etc...}

            List<string> combos = new List<string>();
            Dictionary<char, string> keypad = new Dictionary<char, string>()
            {
                { '2',"abc" },
                { '3', "def" },
                { '4' , "ghi" },
                { '5' , "jkl" },
                { '6' , "mnop" },
                { '7' , "qrs" },
                { '8' , "tuv" },
                { '9' , "wxyz" }
            };
            combos.Add("");

            if (string.IsNullOrEmpty(digits))
                return combos;
            //loop through the string
            for (int i = 0; i < digits.Length; i++) { //digit string loop "23"
                string value = keypad[digits[i]];

                for (int j = 0; j < value.Length; j++) { //keypad loop
                    string s = keypad[digits[i]];
                    combos[j]+=s;
                }
            }

            return combos;
        }
    }
}
