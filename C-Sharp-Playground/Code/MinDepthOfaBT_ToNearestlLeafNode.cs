namespace C_Sharp_Playground.Code
{
    public class MinDepthOfaBT_ToNearestlLeafNode
    {

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int minDepth = int.MaxValue;
            Console.WriteLine(minDepth);
            void GetMinDepth(TreeNode node, int depth)
            {
                if (node.left == null && node.right == null)
                {
                    minDepth = Math.Min(minDepth, depth);
                    return;
                }

                if (node.left != null)
                {
                    GetMinDepth(node.left, depth + 1);
                }

                if (node.right != null)
                {
                    GetMinDepth(node.right, depth + 1);
                }
            }

            GetMinDepth(root, 1);

            return minDepth;
        }


    }
}