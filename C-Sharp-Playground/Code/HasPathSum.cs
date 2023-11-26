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
            Stack<int> s = new Stack<int>();
            bool found = false;
            bool GetToLeaf(TreeNode node, int depth)
            {
                if (found)
                {
                    return found;
                }
                else
                {
                    bool issame = false;
                    if (node.left == null && node.right == null)
                    {
                        s.Push(node.val);
                        if (targetNum == s.Sum())
                        {
                            issame = true;
                            found = true;
                            return issame;
                        }
                        else
                        {
                            s.Pop();
                            issame = false;
                            return issame;
                        }
                    }
                    if (node.left != null)
                    {
                        s.Push(node.val);
                        GetToLeaf(node.left, depth + 1);
                        if (node.right == null)
                        {
                            s.Pop();
                        }
                    }
                    if (node.right != null)
                    {
                        if (node.left == null)
                        {
                            s.Push(node.val);
                        }
                        GetToLeaf(node.right, depth + 1);
                        s.Pop();
                    }
                    issame = found == true ? issame = true : issame = false;
                    return issame;
                }


            }
            return GetToLeaf(root, 1);

        }
    }
}