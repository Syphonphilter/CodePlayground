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

class Program
{


    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(HasPathSumFunc(CreateSampleTree(-2, 2, -3), -2));


    }
    public static TreeNode CreateSampleTree(int a, int b, int c)
    {
        // Creating nodes
        TreeNode root = new TreeNode(a);
        TreeNode node2 = null;
        TreeNode node3 = new TreeNode(c);


        // Building the tree
        root.left = node2;
        root.right = node3;



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
}
