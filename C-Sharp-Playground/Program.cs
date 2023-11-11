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

class Program
{


    static void Main()
    {
        var x = IsSameTree(CreateSampleTree(1, 2, 3), CreateSampleTree(1, 2, 3));
        Console.WriteLine(x);

    }

    public static TreeNode CreateSampleTree(int a, int b, int c)
    {
        // Creating nodes
        TreeNode root = new TreeNode(a);
        TreeNode node2 = null;
        TreeNode node3 = new TreeNode(b);
        TreeNode node4 = new TreeNode(c);

        // Building the tree
        root.left = node2;
        root.right = node3;

        node3.left = node4;

        return root;
    }

    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        // Base case: if both nodes are null, they are the same
        if (p == null && q == null)
            return true;

        // If one node is null and the other is not, they are not the same
        if (p == null || q == null)
            return false;

        // Check if the values are the same and recursively check left and right subtrees
        return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
    public static IList<int> InorderTraversal(TreeNode root)
    {
        Stack<int> stack = new Stack<int>();
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
}
