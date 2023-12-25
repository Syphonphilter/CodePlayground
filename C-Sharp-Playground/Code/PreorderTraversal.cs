namespace C_Sharp_Playground.Code
{
    public class PreorderTraversal
    {
        static IList<int> PreorderTraversalv1(TreeNode root)
        {
            List<int> list = new List<int>();
            list.Add(root.val);

            void visitRoot(TreeNode root)
            {
                if (root != null)
                {
                    list.Add(root.val);
                    if (root.left != null)
                    {
                        visitRoot(root.left);
                    }
                    if (root.right != null)
                    {
                        visitRoot(root.right);
                    }


                }
            }
            visitRoot(root.left);
            visitRoot(root.right);
            return list;
        }
    }
}