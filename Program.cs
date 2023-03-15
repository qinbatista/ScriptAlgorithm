using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 11, 11, 7 };
            int target = 9;
            var algorithmEasy = new AlgorithmEasy();
            var algorithmMedium = new AlgorithmEasy();
            //sum of two numbers
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.TwoSum(nums, target)) + "]");
            // nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Max SubArray
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MaxSubArray(nums)) + "]");
            //move zeroes to last
            // nums = new int[] { 0, 1, 0, 3, 12 };
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MoveZeroes(nums)) + "]");
            //contain duplicate
            // nums = new int[] { 1, 2, 3, 1 };
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.ContainsDuplicate(nums)) + "]");
            //rotate
            // nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.Rotate(nums, 3)) + "]");
            //reverse string
            // char[] charArray = { 'h','e','l','l','o','a'};
            // algorithmEasy.ReverseString(charArray);
            //FizzBuzz
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.FizzBuzz(15)) + "]");
            //Single Number
            // int[] nums_singleNumber = new int[] { 4,1,2,1,2 };
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.SingleNumber(nums_singleNumber) + "]"));
            //Maximum Depth of Binary Tree
            TreeNode root = new TreeNode();
            root.val = 3;
            TreeNode left = new TreeNode();
            left.val = 9;
            root.left = left;
            TreeNode right = new TreeNode();
            left.val = 20;
            root.right = right;
            TreeNode rightLeft = new TreeNode();
            rightLeft.val = 15;
            right.left = rightLeft;
            TreeNode rightRight = new TreeNode();
            rightLeft.val = 7;
            right.right = rightRight;
            // TreeNode root = new TreeNode();
            // root.val = 1;
            // TreeNode right = new TreeNode();
            // right.val = 20;
            // root.right = right;
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MaxDepth(root) + "]"));

            // Console.WriteLine("[" + string.Join(",", algorithmEasy.titleToNumber("AB") + "]"));

            // int[] numbers = new int[] {3,2,3};
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MajorityElement(numbers) + "]"));

            // Console.WriteLine("[" + string.Join(",", algorithmEasy.RomanToInt("III") + "]"));

            // int[] numbers = new int[] {7,1,5,3,6,4};
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MaxProfit(numbers) + "]"));

            // Console.WriteLine("[" + string.Join(",", algorithmEasy.IsAnagram("anagram","nagaram") + "]"));

            // Console.WriteLine("[" + string.Join(",", algorithmEasy.FirstUniqChar("aabb") + "]"));
            // int[] numbers = new int[] {0,1};
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MissingNumber(numbers) + "]"));

            // int[] numbers1 = new int[] {1,2,2,1};
            // int[] numbers2 = new int[] {2,2};
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.Intersect(numbers1,numbers2) + "]"));
            // int[] numbers = new int[] {7,1,5,3,6,4};
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MaxProfit2(numbers) + "]"));
            // ListNode listNode1 = new ListNode();
            // listNode1.val  = 1;
            // listNode1.AddNode(2);
            // listNode1.AddNode(4);

            // ListNode listNode2 = new ListNode();
            // listNode2.val  = 1;
            // listNode2.AddNode(3);
            // listNode2.AddNode(4);
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.MergeTwoLists(listNode1,listNode2) + "]"));

            // Console.WriteLine("[" + string.Join(",", algorithmEasy.climbStairs(2) + "]"));
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.IsSymmetric(root) + "]"));
            // Console.WriteLine("[" + string.Join(",", algorithmEasy.IsPowerOfThree(27) + "]"));
            int[] numbers1 = new int[] {2,7,9,3,1};
            Console.WriteLine("[" + string.Join(",", algorithmEasy.Rob(numbers1) + "]"));


        }
    }
}
