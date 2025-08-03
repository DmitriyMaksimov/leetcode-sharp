namespace leetcode_sharp;

// 1026. Maximum Difference Between Node and Ancestor
// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
public class S01026
{
    public int MaxAncestorDiff(TreeNode? root)
    {
        return FindMaxDiff(root, int.MaxValue, int.MinValue);
    }

    private static int FindMaxDiff(TreeNode? node, int min, int max)
    {
        if (node == null)
        {
            return max - min;
        }

        max = Math.Max(max, node.val);
        min = Math.Min(min, node.val);
        return Math.Max(FindMaxDiff(node.left, min, max), FindMaxDiff(node.right, min, max));
    }
}