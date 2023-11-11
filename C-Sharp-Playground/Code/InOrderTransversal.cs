namespace C_Sharp_Playground.Code
{
    public class InOrderTransversal
    {
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
}