namespace leetcode_sharp;

// 236. Lowest Common Ancestor of a Binary Tree
// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
public class S00236
{
    public TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode? p, TreeNode? q)
    {
        if (root == null || root == p || root == q)
        {
            return root;
        }

        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);
        
        return left == null ? right : right == null ? left : root;
    }
}