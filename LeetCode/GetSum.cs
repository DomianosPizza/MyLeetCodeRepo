using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class GetSum
    {
        public int getSum()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                result += numbers[i]*2;
            }
            return result;
        }
    }
}
