using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string y = x.ToString();
            char[] z = y.ToCharArray();
            char[] a = z.Reverse().ToArray();
            for (int i = 0; i < a.Length;i++)
            {
                if (a[i] != z[i]) { 
                    return false;
                }
            }
            return true;
        }
    }
}
