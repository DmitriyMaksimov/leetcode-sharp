namespace leetcode_sharp;

// 617. Merge Two Binary Trees
// https://leetcode.com/problems/merge-two-binary-trees/
public class S00617
{
    public TreeNode? MergeTrees(TreeNode? root1, TreeNode? root2)
    {
        if (root1 == null)
        {
            return root2;
        }

        if (root2 == null)
        {
            return root1;
        }

        var node = new TreeNode(root1.val + root2.val, MergeTrees(root1.left, root2.left), MergeTrees(root1.right, root2.right));
        
        return node;
    }
}