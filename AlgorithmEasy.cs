﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class AlgorithmEasy
    {
        //create a dictionary to store the value and index
        //if the value is not in the diction, add how many remain value is needed to get the target
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> _value_dic = new Dictionary<int, int>();
            int _remain = 0;
            int[] returnValue = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                _remain = target - nums[i];
                if (_value_dic.ContainsKey(_remain))
                {
                    returnValue[0] = _value_dic[_remain];
                    returnValue[1] = i;
                    return returnValue;
                }
                else
                {
                    if (!_value_dic.ContainsKey(nums[i]))
                        _value_dic.Add(nums[i], value: i);
                }
            }
            return returnValue;
        }

        public int MaxSubArray(int[] nums)
        {
            int current = 0;
            int max_value = -999999;
            for (int i = 0; i < nums.Length; i++)
            {
                current += nums[i];
                if (current > max_value)
                    max_value = current;
                if (current < 0)
                    current = 0;
            }
            return max_value;
        }

        public int[] MoveZeroes(int[] nums)
        {
            // int swap_index = 0;
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (nums[i] == 0 && i < nums.Length - swap_index)
            //     {
            //         nums[i] = nums[nums.Length - swap_index - 1];
            //         nums[nums.Length - swap_index - 1] = 0;
            //         swap_index++;
            //     }
            // }
            int added_values = 0;
            //zip all non 0 values
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[added_values] = nums[i];
                    added_values++;
                }
            }
            //add 0 at back
            for (int i = added_values; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }

        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, bool> table = new Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (table.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    table.Add(nums[i], true);
                }
            }
            return false;
        }

        public int[] Rotate(int[] nums, int k)
        {
            int extra_move = k % nums.Length;
            k = extra_move;
            List<int> frontValue = new List<int>();
            for (int i = nums.Length - k; i < nums.Length; i++)
            {
                frontValue.Add(nums[i]);
            }
            for (int i = nums.Length - k - 1; i >= 0; i--)
            {
                int value = i + k;
                nums[i + k] = nums[i];
            }
            for (int i = 0; i < frontValue.Count; i++)
            {
                nums[i] = frontValue[i];
            }
            return nums;
        }
    }
}
