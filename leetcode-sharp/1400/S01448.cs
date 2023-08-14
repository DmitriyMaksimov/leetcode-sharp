namespace leetcode_sharp;

// 1448. Count Good Nodes in Binary Tree
// https://leetcode.com/problems/count-good-nodes-in-binary-tree/
public class S01448
{
    public int GoodNodes(TreeNode root)
    {
        return dfs(root, int.MinValue);
    }

    private static int dfs(TreeNode? root, int maxVal)
    {
        if (root == null)
        {
            return 0;
        }

        var res = root.val >= maxVal ? 1 : 0;

        res += dfs(root.left, Math.Max(root.val, maxVal));
        res += dfs(root.right, Math.Max(root.val, maxVal));

        return res;
    }
}