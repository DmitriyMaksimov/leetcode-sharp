namespace leetcode_sharp;

// 865. Smallest Subtree with all the Deepest Nodes
// https://leetcode.com/problems/smallest-subtree-with-all-the-deepest-nodes
public class S00865
{
    public TreeNode? SubtreeWithAllDeepest(TreeNode? root)
    {
        return GetMaxDepth(root).node;
    }

    private static (int depth, TreeNode? node) GetMaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return (0, null);
        }

        var (leftDepth, leftNode) = GetMaxDepth(root.left);
        var (rightDepth, rightNode) = GetMaxDepth(root.right);

        return (Math.Max(leftDepth, rightDepth) + 1, leftDepth == rightDepth ? root : leftDepth > rightDepth ? leftNode : rightNode);
    }
}
