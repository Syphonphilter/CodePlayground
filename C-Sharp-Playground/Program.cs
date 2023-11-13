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
        var x = IsSymmetric(CreateSampleTree(1, 2, 2, 3, 4, 4, 3));
    
        Console.WriteLine(x);

    }
    public static TreeNode CreateSampleTree(int a, int b, int c, int d, int e, int f, int g)
    {
        // Creating nodes
        TreeNode root = new TreeNode(a);
        TreeNode node2 = new TreeNode(b);
        TreeNode node3 = new TreeNode(c);
        TreeNode node4 = new TreeNode(d);
        TreeNode node5 = new TreeNode(e);
        TreeNode node6 = new TreeNode(f);
        TreeNode node7 = new TreeNode(g);

        // Building the tree
        root.left = node2;
        root.right = node3;
        node2.left = node4;
        node2.right = node5;
        node3.left = node6;
        node3.right = node7;

        return root;
    }

    public static bool IsSymmetric(TreeNode root)
    {
        TreeNode leftNode = new TreeNode();
        TreeNode rightNode = new TreeNode();
        leftNode = root.left;
        rightNode = root.right;
        //base case 

        if (root == null)
        {
            return false;
        }
        if (leftNode.val != rightNode.val)
        {
            return false;
        }


        return leftNode.left.val == rightNode.right.val && IsSymmetric(leftNode) == IsSymmetric(rightNode);
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
