namespace leetcode_sharp;

// 226. Invert Binary Tree
// https://leetcode.com/problems/invert-binary-tree/
public class S00226
{
    public TreeNode? InvertTree(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        InvertTree(root.left);
        InvertTree(root.right);

        (root.left, root.right) = (root.right, root.left);
        
        return root;
    }
}