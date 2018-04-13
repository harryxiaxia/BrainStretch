using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeFun
{
    public class PlayAround
    {
        //3. Longest Substring Without Repeating Characters
        public int LengthOfLongestSubstring(string s)
        {
            int count = 0;
            var dic = new Dictionary<Char, int>();
            for (int i = 0; i < s.Length; i++)
                if (!dic.Keys.Contains(s.ElementAt(i)))
                    dic.Add(s.ElementAt(i), i);
                else
                {
                    int j = i;
                    i = dic[s.ElementAt(i)];
                    while (j < s.Length && dic.Keys.Contains(s.ElementAt(j)))
                    {
                        i = dic[s.ElementAt(j)] > i ? dic[s.ElementAt(j)] : i;
                        j++;
                    }
                    count = dic.Count > count ? dic.Count : count;
                    dic.Clear();
                    dic.Add(s.ElementAt(i + 1), i + 1);
                }

            count = dic.Count > count ? dic.Count : count;
            return count;
        }
    }


    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {

        public bool IsBalanced(TreeNode root)
        {
            if (root == null) throw new Exception("Root it null.");
            return Math.Abs(Height(root.left)-Height(root.right)) <= 1;
        }

        public int Height(TreeNode node)
        {
            if (node == null) return -1;
            return Math.Max(Height(node.left), Height(node.right)) + 1;
        }

        //236. Lowest Common Ancestor of a Binary Tree
        //I should find something run faster
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            return Lca(root, p, q);
        }

        public TreeNode Lca_Copy(TreeNode node, TreeNode p, TreeNode q)
        {
            if (node == null || node == p || node == q) return node;
            TreeNode left = Lca_Copy(node.left, p, q);
            TreeNode right = Lca_Copy(node.right, p, q);
            if (right != null && left != null) return node;
            return left ?? right;
        }

        public TreeNode Lca(TreeNode node, TreeNode p, TreeNode q)
        {
            if (node.left != null && HasAncestorRelation(node.left, p) && HasAncestorRelation(node.left, q))
                Lca(node.left, p, q);
            if (node.right != null && HasAncestorRelation(node.right, p) && HasAncestorRelation(node.right, q))
                Lca(node.right, p, q);
            return node;
        }

        private bool HasAncestorRelation(TreeNode n1, TreeNode n2)
        {
            //Bfs
            if (n1 == n2) return true;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(n1);
            while(queue.Count > 0)
            {
                var item = queue.Dequeue();
                if (item.left != null)
                {
                    if (item.left == n2) return true;
                    else queue.Enqueue(item.left);
                }
                if(item.right != null)
                {
                    if (item.right == n2) return true;
                    else queue.Enqueue(item.right);
                }
            }
            return false;
        }

        public TreeNode Lca_Crack(TreeNode node, TreeNode p, TreeNode q)
        {
            if (HasAncestorRelation_Crack(node.left, p) && HasAncestorRelation_Crack(node.left, q))
                Lca_Crack(node.left, p, q);
            if (HasAncestorRelation_Crack(node.right, p) && HasAncestorRelation_Crack(node.right, q))
                Lca_Crack(node.right, p, q);
            return node;
        }

        private bool HasAncestorRelation_Crack(TreeNode n1, TreeNode n2)
        {
            if (n1 == null) return false;
            if (n1 == n2) return true;
            return HasAncestorRelation(n1.left, n2) || HasAncestorRelation(n1.right, n2);
        }

    }
}
