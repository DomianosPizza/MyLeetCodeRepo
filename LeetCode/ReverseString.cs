using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseString
    {

        public string reverseStr(string str)
        {
            var reversedStr = "";

            for (int i = str.Length-1; i>0; i--)
            {
                reversedStr += str[i];
            }

            return reversedStr;
        }

    }
}
