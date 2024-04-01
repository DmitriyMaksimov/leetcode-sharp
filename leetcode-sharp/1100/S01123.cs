namespace leetcode_sharp;

// 1123. Lowest Common Ancestor of Deepest Leaves
// https://leetcode.com/problems/lowest-common-ancestor-of-deepest-leaves
public class S01123
{
    private readonly Dictionary<TreeNode, int> _depths = [];

    public TreeNode? LcaDeepestLeaves(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        var leftDepth = CalculateDepth(root.left);
        var rightDepth = CalculateDepth(root.right);
        
        if (leftDepth == rightDepth)
        {
            return root;
        }

        return LcaDeepestLeaves(leftDepth < rightDepth ? root.right : root.left);
    }

    private int CalculateDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        if (_depths.TryGetValue(root, out var value))
        {
            return value;
        }

        return _depths[root] = Math.Max(CalculateDepth(root.left), CalculateDepth(root.right)) + 1;
    }
}