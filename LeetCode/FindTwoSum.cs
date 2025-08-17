using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindTwoSum
    {
        //ASSUME THAT EACH ARRAY ONLY HAS 1 ANSWER
        public int[] TwoSum(int[] nums, int target)
        {
            int temp = 0;
            int[] answer = new int[2];
            foreach (int num in nums)
            {
                temp = target - num;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (temp == nums[i])
                    {
                        answer[0] = num;
                        answer[1] = i;
                        return answer;
                    }
                }
            }
            return answer;
            
        }
    }
}
