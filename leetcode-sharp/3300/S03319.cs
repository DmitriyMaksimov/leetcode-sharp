namespace leetcode_sharp;

// 3319. K-th Largest Perfect Subtree Size in Binary Tree
// https://leetcode.com/problems/k-th-largest-perfect-subtree-size-in-binary-tree
public class S03319
{
    public int KthLargestPerfectSubtree(TreeNode? root, int k)
    {
        List<int> res = [];
        Dfs(root, res);
        res.Sort();

        if (k <= res.Count)
        {
            return (1 << res[^k]) - 1;
        }

        return -1;
    }

    private static int Dfs(TreeNode? root, List<int> res)
    {
        if (root == null)
        {
            return 0;
        }

        var left = Dfs(root.left, res);
        var right = Dfs(root.right, res);

        if (left == right && left >= 0)
        {
            res.Add(left + 1);
            return left + 1;
        }

        return -1;
    }
}
