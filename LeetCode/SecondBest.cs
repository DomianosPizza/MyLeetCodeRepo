using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SecondBest
    {


        public int secondBest(int[] arr) 
        {
            int highTemp = arr[1];
            int highest = 0;
            int lowTemp=arr[1];
            int low = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > highTemp) {
                    highest = highTemp;
                    highTemp = arr[i]; 
                }
                if (arr[i] < lowTemp) {
                    low = lowTemp;
                    lowTemp = arr[i];
                }
            }
            Console.WriteLine(highest + " " + low);
            return low + highest;
        }
    }
}
