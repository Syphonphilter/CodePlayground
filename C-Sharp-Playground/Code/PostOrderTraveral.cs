namespace C_Sharp_Playground.Code
{
    public class PostOrderTraveral
    {
        static IList<int> PostOrderTraversalv1(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null)
            {
                return list;
            }

            void traverse(TreeNode root)
            {
                // Check if the node has any child
                if (root.left != null || root.right != null || (root.left != null && root.right != null))
                {   // traverse left
                    if (root.left != null)
                    {
                        traverse(root.left);
                        list.Add(root.val);
                    }
                    //traverse right
                    if (root.right != null)
                    {
                        traverse(root.right);
                        list.Add(root.val);
                    }
                }
                else
                {
                    list.Add(root.val);
                }
            }
            if (root.left != null)
            {

                traverse(root.left);
            }
            if (root.right != null)
            {

                traverse(root.right);
            }
            list.Add(root.val);

            return list;

        }
    }
}