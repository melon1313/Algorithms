using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class InsertionSort
    {
        public static void InsertionSortByLoop(int[] nums)
        {
            for(int round = 0; round < nums.Length; round++)
            {
                for(int iRun = round; iRun > 0; iRun--)
                {
                    if (nums[iRun] > nums[iRun - 1])
                    {
                        Swap(nums, iRun - 1, iRun);
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

        public static void InsertionSortByRecursion(int[] nums)
        {
            int round = 0;
            RoundRecursion(nums, round);
        }

        private static void RoundRecursion(int[] nums, int round)
        {
            if (round >= nums.Length) return;

            int iRun = round;
            SwapRecursion(nums, iRun);

            RoundRecursion(nums, round + 1);
        }

        private static void SwapRecursion(int[] nums, int iRun)
        {
            if (iRun <= 0) return;

            if (nums[iRun] > nums[iRun - 1])
            {
                Swap(nums, iRun - 1, iRun);
            }
            else
            {
                return;
            }
            
            SwapRecursion(nums, iRun - 1);
        }

        private static void Swap(int[] nums, int iLeftIdx, int iRightIdx)
        {
            int tempValue = nums[iLeftIdx];
            nums[iLeftIdx] = nums[iRightIdx];
            nums[iRightIdx] = tempValue;
        }
    }
}
