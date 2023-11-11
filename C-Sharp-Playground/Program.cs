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
        if ((p != null && q == null) || (p == null && q != null))
        {
            return false;
        }
        Stack<int> stack = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        void Traverse(TreeNode node, bool isq)
        {
            if (node == null)
            {
                return;
            }
            Traverse(node.left, isq);
            if (isq)
            {
                stack.Push(node.val);
            }
            else
            {
                stack2.Push(node.val);
            }
            Traverse(node.right, isq);
        }
        Traverse(p, false);
        Traverse(q, true);
        return stack.Reverse().ToList().SequenceEqual(stack2.Reverse().ToList());
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
