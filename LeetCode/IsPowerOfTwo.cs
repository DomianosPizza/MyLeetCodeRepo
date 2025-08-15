using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsPowerOfTwo
    {
        public bool PowerOfTwo(int n)
        {
            double temp = Math.Log2(n);
            double domath = Math.Ceiling(temp) - temp;
            if (n == 1) return true;
            if (domath > 0 || n == 0 || n < 0) return false;
            else return true;

        }
    }
}
