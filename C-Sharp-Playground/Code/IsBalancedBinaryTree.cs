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
            static int GetDept(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                int leftDepth = GetDept(root.left);
                int rightDepth = GetDept(root.right);

                return Math.Max(leftDepth, rightDepth) + 1;
            }
            int leftDepth = GetDept(root.left);
            int rightDepth = GetDept(root.right);
            return Math.Abs(leftDepth - rightDepth) <= 1;
        }
    }
}