using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum of two numbers
            int[] nums = new int[] { 2, 11, 11, 7 };
            int target = 9;
            var algorithmEasy = new AlgorithmEasy();
            Console.WriteLine("[" + string.Join(",", algorithmEasy.TwoSum(nums, target)) + "]");
        }
    }
}
