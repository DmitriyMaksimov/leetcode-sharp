namespace leetcode_sharp;

// 814. Binary Tree Pruning
// https://leetcode.com/problems/binary-tree-pruning
public class S00814
{
    public TreeNode? PruneTree(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        root.left = PruneTree(root.left);
        root.right = PruneTree(root.right);
        
        if (root.left == null && root.right == null && root.val == 0)
        {
            return null;
        }

        return root;
    }
}