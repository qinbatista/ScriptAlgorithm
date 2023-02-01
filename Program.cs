using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 11, 11, 7 };
            int target = 9;
            var algorithmEasy = new AlgorithmEasy();
            // //sum of two numbers
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.TwoSum(nums, target)) + "]");
            // nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            // //Max SubArray
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MaxSubArray(nums)) + "]");
            // //move zeroes to last
            // nums = new int[] { 0, 1, 0, 3, 12 };
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MoveZeroes(nums)) + "]");
            //contain duplicate
            nums = new int[] { 1, 2, 3, 1 };
            Console.WriteLine("[" + string.Join(",", algorithmEasy.ContainsDuplicate(nums)) + "]");
            //rotate
            nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("[" + string.Join(",", algorithmEasy.Rotate(nums, 3)) + "]");
        }
    }
}
