using System;
using System.Collections.Generic;

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
    }
}
