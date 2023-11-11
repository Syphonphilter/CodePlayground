namespace C_Sharp_Playground.Code
{
    public class CompareBinaryTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
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
    }
}