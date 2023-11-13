namespace C_Sharp_Playground.Code
{
    public class SymmetricTree
    {
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

    }
}