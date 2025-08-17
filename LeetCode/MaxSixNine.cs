using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaxSixNine
    {
        public int Max69(int num) {
            string stringNumber = num.ToString();
            string currentString = "";
            int changeCount = 0;
            int highestNumber = num;
            for (int i = 0; i < stringNumber.Length; i++)
            {
                if (stringNumber[i] == '6' && changeCount < 1)
                {
                    currentString += '9';
                    changeCount++;
                }
                else
                {
                    currentString += stringNumber[i];
                }
                if (Int32.Parse(currentString) > highestNumber) highestNumber = Int32.Parse(currentString);
            }
            return highestNumber;
        }
    }
}
