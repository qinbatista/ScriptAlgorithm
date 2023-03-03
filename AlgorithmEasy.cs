using System;
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
                    return true;
                else
                    table.Add(nums[i], true);
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

        public void ReverseString(char[] s)
        {
            char temp = 'a';
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
            Console.WriteLine("[" + string.Join(",", s) + "]");
        }

        public IList<string> FizzBuzz(int n)
        {
            string _str = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    _str = _str + "," + "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    _str = _str + "," + "Fizz";
                }
                else if (i % 5 == 0)
                {
                    _str = _str + "," + "Buzz";
                }
                else
                {
                    if (_str == "")
                        _str = _str + i;
                    else
                        _str = _str + "," + i;
                }
            }
            return _str.Split(",").ToList();
        }

        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = 1;
                }
                else
                {
                    dic[nums[i]] = dic[nums[i]] + 1;
                }
            }
            foreach (KeyValuePair<int, int> item in dic)
            {
                if (item.Value == 1)
                    return item.Key;
            }
            return -1;
        }

        public int MaxDepth(TreeNode root)
        {
            return findDeep(root);
        }

        public int findDeep(TreeNode root)
        {
            if (root == null)
                return 0;
            // if (root.left != null && root.left.val != null)
            int leftDeep = findDeep(root.left);
            // if (root.right != null && root.left.val != null)
            int rightDeep = findDeep(root.right);
            if (leftDeep > rightDeep)
                return leftDeep + 1;
            else
                return rightDeep + 1;
        }

        public int titleToNumber(string columnTitle)
        {
            int sum = 0;
            for (int i = 0; i < columnTitle.Length; i++)
                sum = sum + (int)Math.Pow(26, (columnTitle.Length - i - 1)) * (columnTitle[i] - 64);
            return sum;
        }

        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int max = 0;
            int value = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]] = dic[nums[i]] + 1;
                }
                if (dic[nums[i]] > max)
                {
                    max = dic[nums[i]];
                    value = nums[i];
                }
            }
            return value;
        }

        public int RomanToInt(string s)
        {
            if (s == null || s == string.Empty)
                return 0;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int result = 0;
            dict.Add("I", 1);
            dict.Add("V", 5);
            dict.Add("X", 10);
            dict.Add("L", 50);
            dict.Add("C", 100);
            dict.Add("D", 500);
            dict.Add("M", 1000);
            string current = "";
            string next = "";
            for (int i = 0; i < s.Length; i++)
            {
                current = "";
                next = "";
                current = s[i].ToString();
                if (i + 1 < s.Length)
                    next = s[i + 1].ToString();
                if (next != "" && dict[current] < dict[next])
                {
                    result = result - dict[current];
                }
                else
                {
                    result = result + dict[current];
                }
            }
            return result;
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

        public int MaxProfit(int[] prices)
        {
            int yesterday = int.MaxValue;
            int sum = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (yesterday < prices[i])
                    sum = sum + prices[i] - yesterday;
                yesterday = prices[i];
            }
            return sum;
        }

        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic_s = new Dictionary<char, int>();
            Dictionary<char, int> dic_t = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic_s.ContainsKey(s[i]))
                    dic_s.Add(s[i], 1);
                else
                    dic_s[s[i]] = dic_s[s[i]] + 1;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!dic_t.ContainsKey(t[i]))
                    dic_t.Add(t[i], 1);
                else
                    dic_t[t[i]] = dic_t[t[i]] + 1;
            }
            foreach (KeyValuePair<char, int> s_value in dic_s)
            {
                if (!dic_t.ContainsKey(s_value.Key))
                    return false;
                if (dic_t[s_value.Key] != s_value.Value)
                    return false;
            }
            foreach (KeyValuePair<char, int> t_value in dic_t)
            {
                if (!dic_s.ContainsKey(t_value.Key))
                    return false;
                if (dic_s[t_value.Key] != t_value.Value)
                    return false;
            }
            return true;
        }

        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                }
                else
                {
                    dic[s[i]] = -1;
                }
            }
            foreach (KeyValuePair<char, int> item in dic)
            {
                if (item.Value != -1)
                    return item.Value;
            }
            return -1;
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            return BuildTree(nums, 0, nums.Length - 1);
        }

        private TreeNode BuildTree(int[] nums, int i, int j)
        {
            if (j < i)
                return null;
            int mid = j + (i - j) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = BuildTree(nums, i, mid - 1);
            node.right = BuildTree(nums, mid + 1, j);
            return node;
        }

        public int MissingNumber(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
            }
            for (int i = 0; i <= nums.Length; i++)
            {
                if(!dic.ContainsKey(i))
                    return i;
            }
            return -1;
        }
    }
}
