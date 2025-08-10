using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class InterviewQuestion
    {
        //write a function that takes in an int and returns a boolean. if given year is leap year
        //multiple of 400 
        //multiple of 4 and not a multiple of 100

        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            if(year % 4 == 0  && year  % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
