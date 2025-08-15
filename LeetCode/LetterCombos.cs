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
            
            foreach(char digit in digits) //Foreach digit in our digits string
            {
                string letters = keypad[digit];
                List<string> formCombos = new List<string>();
                foreach (string bunchedLetter in combos) {
                    foreach (char letter in letters) {
                        //combos.Add(bunchedLetter + letter); we can't directly add onto combos because it hanges the frst for loop
                        formCombos.Add(bunchedLetter + letter);
                    }
                }
                combos = formCombos;
            }

            return combos;
        }
    }
}
