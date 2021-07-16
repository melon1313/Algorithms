using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SelectionSort
    {
        public static void SelectionSortByLoop(int[] nums)
        {
            for (int round = 0; round < nums.Length; round++)
            {
                int iMax = round;
                for (int iRun = round + 1; iRun < nums.Length; iRun++)
                {
                    if (nums[iRun] > nums[iMax])
                    {
                        iMax = iRun;
                    }
                }

                Swap(nums, round, iMax);
            }
        }

        public static void SelectionSortByRecursion(int[] nums)
        {
            int round = 0;
            RoundRecursion(nums, round);
        }

        private static void RoundRecursion(int[] nums, int round)
        {
            if (round >= nums.Length) return;

            int iRun = round + 1;
            int iMax = round;
            iMax = GetMaxIdx(nums, iRun, iMax);

            Swap(nums, round, iMax);

            RoundRecursion(nums, round + 1);
        }

        private static int GetMaxIdx(int[] nums, int iRun, int iMax)
        {
            if (iRun >= nums.Length) return iMax;

            if(nums[iRun] > nums[iMax])
            {
                iMax = iRun;
            }

            return GetMaxIdx(nums, iRun + 1, iMax);
        }

        private static void Swap(int[] nums, int iLeftIdx, int iRightIdx)
        {
            int tempValue = nums[iLeftIdx];
            nums[iLeftIdx] = nums[iRightIdx];
            nums[iRightIdx] = tempValue;
        }
    }
}
