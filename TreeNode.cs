using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Trie
    {
        Dictionary<string, bool> trie;
        public Trie()
        {
            trie = new Dictionary<string, bool>();
        }

        public void Insert(string word)
        {
            if (!trie.ContainsKey(word))
                trie.Add(word, true);
        }

        public bool Search(string word)
        {
            if (trie.ContainsKey(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool StartsWith(string prefix)
        {
            foreach (KeyValuePair<string, bool> item in trie)
            {
                if (item.Key.StartsWith(prefix))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
