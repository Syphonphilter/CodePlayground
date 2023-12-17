
using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using C_Sharp_Playground.Code;
using Playground.Code;
using Xunit.Sdk;
using System.Numerics;
using C_Sharp_Playground.Code.Functions;
using System.Collections;
using C_Sharp_Playground.Code.Concepts;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Runtime.InteropServices;
using C_Sharp_Playground.Code.Utils;

class Program
{


    static void Main()
    {
        int[] nums = { 4 };
        var x = sLidingWindowSingleNo(nums);
        Console.WriteLine(x);

    }

    #region misc

    public static TreeNode CreateSampleTree(int a, int b, int c, int d, int e, int f, int g, int h)
    {
        // Creating nodes
        TreeNode root = new TreeNode(a);
        TreeNode node2 = new TreeNode(b);
        TreeNode node3 = new TreeNode(c);
        TreeNode node4 = new TreeNode(d);
        TreeNode node5 = new TreeNode(e);
        TreeNode node6 = new TreeNode(f);
        TreeNode node7 = null; // Representing 'null' for the seventh node
        TreeNode node8 = new TreeNode(h);

        // Building the tree
        root.left = node2;
        root.right = node3;

        node2.left = node4;
        node2.right = node5;

        node3.left = node6;
        node3.right = node7;

        node4.left = node8; // Attaching node8 as the left child of node4

        return root;
    }
    public static int MaxDepth(TreeNode root)
    {
        var leftNode = root.left;
        var rightNode = root.right;
        int depth = 1;
        // Base Case
        if (root == null)
        {
            depth = 0;
        }

        else
        {
            void Traverse(TreeNode node)
            {

                if (node.left == null && node.right == null)
                {
                    return;
                }

                Traverse(node.left);
                Traverse(node.right);
                depth++;
            }
            Traverse(root);
        }
        return depth;
    }
    public static int MaxDepth_3(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftDepth = MaxDepth_3(root.left);
        int rightDepth = MaxDepth_3(root.right);

        return Math.Max(leftDepth, rightDepth) + 1;
    }
    public static int MaxDepth_2(TreeNode root)
    {

        int depth = 1;
        // Base Case
        if (root == null)
        {
            depth = 0;
        }

        else
        {
            var leftNode = root.left;
            var rightNode = root.right;
            int getDepth(TreeNode node)
            {
                int temp_depth = 1;
                if (node.left == null && node.right == null)
                {

                }
                else
                {
                    temp_depth++;
                    getDepth(node.left);
                    getDepth(node.right);
                }

                return temp_depth;

            }
            depth = int.Max(getDepth(leftNode.left), getDepth(rightNode.right));
        }
        return depth;
    }

    public static bool IsSymmetric(TreeNode root)
    {

        var leftNode = root.left;
        var rightNode = root.right;
        //base case 
        bool checkSymmetry(TreeNode left, TreeNode right)
        {
            // Check if both left and right nodes are null
            if (left == null && right == null)
            {
                return true;
            }

            // Check if the values of left and right nodes are not equal
            if (left != null && right != null && left.val != right.val)
            {
                return false;
            }

            // Check if either left or right node is null while the other is not
            if ((left == null && right != null) || (left != null && right == null))
            {
                return false;
            }

            // Recursively check the symmetry of child nodes
            return checkSymmetry(left.left, right.right) && checkSymmetry(left.right, right.left);
        }



        return checkSymmetry(leftNode, rightNode);
    }
    public static IList<int> InorderTraversal(TreeNode root)
    {
        Stack<int> stack = new Stack<int>();
        int depth = 1;
        void Traverse(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Traverse(node.left);
            stack.Push(node.val);
            Traverse(node.right);
        }

        Traverse(root);
        Console.WriteLine("hre");
        return stack.Reverse().ToList();
    }
    public static TreeNode SortedArrayToBST(int[] nums)
    {

        TreeNode node;
        //base case 
        if (nums.Length <= 1)
            return node = new TreeNode(nums[nums[0]]);

        static TreeNode BuildTreeFromLeaves(int[] leaves, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            // Find the middle index
            int mid = (left + right) / 2;

            // Create a new TreeNode using the middle element
            TreeNode node = new TreeNode(leaves[mid]);

            // Recursively build the left and right subtrees
            node.left = BuildTreeFromLeaves(leaves, left, mid - 1);
            node.right = BuildTreeFromLeaves(leaves, mid + 1, right);

            return node;
        }
        return BuildTreeFromLeaves(nums, 0, nums.Length - 1);

    }
    public static bool HasPathSumFunc(TreeNode root, int targetNum)
    {
        if (root == null)
        {
            return false;
        }


        Stack<int> s = new Stack<int>();
        bool found = false;
        bool GetToLeaf(TreeNode node, int depth)
        {
            bool issame = false;

            if (node.left == null && node.right == null)
            {
                s.Push(node.val);
                if (targetNum == s.Sum())
                {
                    issame = true;
                    found = true;
                    return issame;
                }
                else
                {
                    s.Pop();

                    issame = false;
                    return issame;
                }
            }

            if (node.left != null)
            {
                s.Push(node.val);
                GetToLeaf(node.left, depth + 1);
                if (node.right == null)
                {
                    s.Pop();
                }

            }

            if (node.right != null)
            {
                if (node.left == null)
                {
                    s.Push(node.val);
                }

                GetToLeaf(node.right, depth + 1);
                s.Pop();


            }
            issame = found == true ? issame = true : issame = false;
            return issame;
        }



        return GetToLeaf(root, 1);

    }
    public static IList<IList<int>> Generate(int numRows)
    {
        List<List<int>> row = new List<List<int>>();
        // current list state
        List<int> current = new List<int>();
        for (int i = 1; i <= numRows; i++)
        {
            List<int> cells = new List<int>();
            int elementsToMid = i % 2 == 0 ? i / 2 : Math.Abs(i / 2) + 1;
            if (i <= 2)
            {
                current.Add(1);
                cells = current;
            }
            else
            {
                cells.Add(1);
                for (int j = 0; j <= elementsToMid - 1; j++)
                {
                    if (j == elementsToMid - 1)
                    {
                        Console.WriteLine(j);
                    }
                    else
                    {
                        cells.Add(current[j] + current[j + 1]);
                    }
                }
                List<int> rcells = i % 2 == 0 ? new List<int>(cells) : cells.Take(cells.Count - 1).ToList();
                rcells.Reverse();
                cells.AddRange(rcells);
            }
            row.Add(new List<int>(cells));
            current = cells;

        }
        return row.ToArray();

    }

    #endregion

    public static int MaxProfit(int[] prices)
    {

        if (prices.Length == 0)
        {
            return 0;
        }
        int max = 0;
        int minPos = Array.IndexOf(prices, prices.Min());
        prices = prices[minPos..];
        for (int i = 0; i < prices.Length - 1; i++)
        {
            int[] tempPrices = { };
            int currentDay = prices[i];
            tempPrices = prices[(i + 1)..];
            int currentProfit = tempPrices.Max() - currentDay;
            max = currentProfit > max ? currentProfit : max;

        }
        return max;
    }

    public static bool isPalindrome(string s)
    {
        s = s.ToLower();
        bool response;
        char[] inputArray = (from c in s where Char.IsLetter(c) || Char.IsDigit(c) select c).ToArray();
        string reverse = string.Join("", inputArray.Reverse());
        string final = string.Join("", inputArray);
        response = reverse == final ? true : false;
        return response;
    }
    public static int sLidingWindowSingleNo(int[] nums)
    {
        List<int> windowValues = new List<int>();
        if (nums.Length == 1)
        {
            return nums[0];
        }
        else
        {
            Dictionary<int, int> keys = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (windowValues.Contains(nums[i]))
                {
                    keys.Add(nums[i], nums[i]);
                    windowValues.Remove(nums[i]);
                }
                else
                {
                    windowValues.Add(nums[i]);
                }

            }
            foreach (var item in windowValues)
            {
                if (keys.ContainsKey(item))
                {
                    windowValues.Remove(item);
                }
            }

            return windowValues[0];
        }
    }
}


