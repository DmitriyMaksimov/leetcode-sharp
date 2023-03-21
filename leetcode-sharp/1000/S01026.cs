namespace leetcode_sharp;

// 1026. Maximum Difference Between Node and Ancestor
// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
public class S01026
{
    public int MaxAncestorDiff(TreeNode root)
    {
        var min = int.MaxValue;
        var max = int.MinValue;

        return findMaxDiff(root, min, max);
    }

    private static int findMaxDiff(TreeNode node, int min, int max)
    {
        if (node == null) return max - min;

        max = Math.Max(max, node.val);
        min = Math.Min(min, node.val);
        return Math.Max(findMaxDiff(node.left, min, max), findMaxDiff(node.right, min, max));
    }
}