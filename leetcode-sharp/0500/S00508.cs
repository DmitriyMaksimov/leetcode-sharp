namespace leetcode_sharp;

// 508. Most Frequent Subtree Sum
// https://leetcode.com/problems/most-frequent-subtree-sum
public class S00508
{
    private readonly Dictionary<int, int> _counts = [];
    private int _maxCount;

    public int[] FindFrequentTreeSum(TreeNode? root)
    {
        Dfs(root);

        return _counts.Where(x => x.Value == _maxCount).Select(x => x.Key).ToArray();
    }

    private int Dfs(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var s = Dfs(root.left) + Dfs(root.right) + root.val;

        _counts[s] = _counts.GetValueOrDefault(s) + 1;
        _maxCount = Math.Max(_maxCount, _counts[s]);

        return s;
    }
}
