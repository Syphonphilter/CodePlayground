/// <summary>
/// The HeightBalancedBinaryTree class represents a binary search tree (BST) and provides a method to construct a balanced BST from a sorted array of integers.
/// </summary>
public class HeightBalancedBinaryTree
{
    /// <summary>
    /// Constructs a balanced binary search tree (BST) from a sorted array of integers.
    /// </summary>
    /// <param name="nums">An array of integers representing the elements to be inserted into the BST.</param>
    /// <returns>The root node of the balanced binary search tree.</returns>
    public TreeNode SortedArrayToBST(int[] nums)
    {
        TreeNode node;
        //base case 
        if (nums.Length <= 1)
            return node = new TreeNode(nums[nums[0]]);


        TreeNode BuildTreeFromLeaves(int[] leaves, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            // Find the middle index
            int mid = (left + right) / 2;

            // Create a new TreeNode using the middle element
            TreeNode node = new TreeNode(leaves[mid]);

            // Recursively build the left and right subtrees
            node.left = BuildTreeFromLeaves(leaves, left, mid - 1);
            node.right = BuildTreeFromLeaves(leaves, mid + 1, right);

            return node;
        }
        return BuildTreeFromLeaves(nums, 0, nums.Length - 1);
    }
}