namespace C_Sharp_Playground.Code
{
    public class SymmetricTree
    {
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
    }
}