namespace leetcode_sharp;

// 337. House Robber III
// https://leetcode.com/problems/house-robber-iii
public class S00337
{
    public int Rob(TreeNode? root)
    {
        var num = Dfs(root);
        return Math.Max(num.maxIfRob, num.maxIfNot);
    }

    private static (int maxIfRob, int maxIfNot) Dfs(TreeNode? x)
    {
        if (x == null)
        {
            return (0, 0);
        }

        var left = Dfs(x.left);
        var right = Dfs(x.right);

        return (left.maxIfNot + right.maxIfNot + x.val, Math.Max(left.maxIfRob, left.maxIfNot) + Math.Max(right.maxIfRob, right.maxIfNot));
    }
}
