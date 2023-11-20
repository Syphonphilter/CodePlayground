namespace C_Sharp_Playground.Code
{
    public class IsBalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int GetDepth(TreeNode node)
            {
                if (node == null)
                {
                    return 0;
                }

                return Math.Max(GetDepth(node.left), GetDepth(node.right)) + 1;
            }

            return Math.Abs(GetDepth(root.left) - GetDepth(root.right)) <= 1;
        }




        public bool IsBalanced2(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int GetDepth(TreeNode node)
            {
                if (node == null)
                {
                    return 0;
                }

                int leftDepth = GetDepth(node.left);
                if (leftDepth == -1)
                {
                    return -1;
                }

                int rightDepth = GetDepth(node.right);
                if (rightDepth == -1)
                {
                    return -1;
                }

                if (Math.Abs(leftDepth - rightDepth) > 1)
                {
                    return -1;
                }

                return Math.Max(leftDepth, rightDepth) + 1;
            }

            return GetDepth(root) != -1;
        }
    }
}