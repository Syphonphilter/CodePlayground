namespace C_Sharp_Playground.Code
{
    public class HasPathSum
    {
        public bool HasPathSumFunc(TreeNode root, int targetNum)
        {
            if (root == null)
            {
                return false;
            }


            int sumOfNodes = 0;
            bool GetToLeaf(TreeNode node, int depth)
            {
                bool issame = false;
                if (node.left == null && node.right == null)
                {
                    if (targetNum == sumOfNodes)
                    {
                        issame = true;
                    }
                    else
                    {
                        issame = false;
                    }
                }

                if (node.left != null)
                {
                    sumOfNodes += node.val;
                    GetToLeaf(node.left, depth + 1);

                }

                if (node.right != null)
                {
                    sumOfNodes += node.val;
                    GetToLeaf(node.right, depth + 1);

                }
                return issame;
            }



            return GetToLeaf(root, 1); 

        }
    }
}