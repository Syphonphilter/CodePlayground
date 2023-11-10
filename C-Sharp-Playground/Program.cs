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

class Program
{


    static void Main()
    {
        var x = InorderTraversal(CreateSampleTree());
        Console.WriteLine(x);

    }

    public static TreeNode CreateSampleTree()
    {
        // Creating nodes
        TreeNode root = new TreeNode(1);
        TreeNode node2 = null;
        TreeNode node3 = new TreeNode(2);
        TreeNode node4 = new TreeNode(3);

        // Building the tree
        root.left = node2;
        root.right = node3;

        node3.left = node4;

        return root;
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

        return stack.Reverse().ToList();
    }
}
