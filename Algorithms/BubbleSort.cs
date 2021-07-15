using System;

namespace Algorithms
{
    public class BubbleSort
    {
		public static void BubbleSortByLoop(int[] nums)
		{
            for (int round = 0; round < nums.Length; round++)
            {
                int len = nums.Length - round;
                for (int iRun = 1; iRun < len; iRun++)
                {
                    if (nums[iRun - 1] > nums[iRun])
                    {
                        Swap(nums, iRun - 1, iRun);
                    }
                }
            }
        }

		public static void BubbleSortByRecursion(int[] nums) 
		{
			int round = 0;
			RoundRecursion(nums, round);
		}

        private static void RoundRecursion(int[] nums, int round)
        {
			if (round >= nums.Length) return;

			int len = nums.Length - round;
			int iRun = 1;

			SwapRecursion(nums, iRun, len);

			RoundRecursion(nums, round + 1);
		}

        private static void SwapRecursion(int[] nums, int iRun, int len)
        {
			if (iRun >= len) return;

			if (nums[iRun - 1] > nums[iRun])
			{
				Swap(nums, iRun - 1, iRun);
			}

			SwapRecursion(nums, iRun + 1, len);

		}

        private static void Swap(int[] nums, int iLeftIdx, int iRightIdx)
		{
			int tempValue = nums[iLeftIdx];
			nums[iLeftIdx] = nums[iRightIdx];
			nums[iRightIdx] = tempValue;
		}
	}
}
