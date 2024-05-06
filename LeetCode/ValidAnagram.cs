using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            string[] a = s.Split("").ToArray();
            string[] b = t.Split("").ToArray();
            for(int i =0; i < a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }



            return false;
        }
    }
}
