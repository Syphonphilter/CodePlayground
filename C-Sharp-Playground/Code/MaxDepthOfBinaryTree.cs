namespace C_Sharp_Playground.Code
{
    public class MaxDepthOfBinaryTree
    {

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

    }
}