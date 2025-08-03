namespace leetcode_sharp;

// 235. Lowest Common Ancestor of a Binary Search Tree
// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
public class S00235
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root.val > p.val && root.val > q.val) return LowestCommonAncestor(root.left!, p, q);
        if (root.val < p.val && root.val < q.val) return LowestCommonAncestor(root.right!, p, q);
        return root;
    }
}