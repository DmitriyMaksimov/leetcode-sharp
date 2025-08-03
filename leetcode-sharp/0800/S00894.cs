namespace leetcode_sharp;

// 894. All Possible Full Binary Trees
// https://leetcode.com/problems/all-possible-full-binary-trees/
public class S00894
{
    private readonly List<List<TreeNode>> _dp = [];

    public IList<TreeNode> AllPossibleFBT(int n)
    {
        for (var i = 0; i <= n; i++)
        {
            _dp.Add([]);
        }

        return solve(n);
    }

    private List<TreeNode> solve(int n)
    {
        if (n % 2 == 0)
        {
            return [];
        }

        if (_dp[n].Any())
        {
            return _dp[n];
        }

        if (n == 1)
        {
            var newNode = new TreeNode(0);
            var result = new List<TreeNode> {newNode};
            return result;
        }

        var res = new List<TreeNode>();

        for (var i = 1; i < n; i += 2)
        {
            var left = solve(i);
            var right = solve(n - i - 1);

            foreach (var l in left)
            {
                foreach (var r in right)
                {
                    var root = new TreeNode(0)
                    {
                        left = l,
                        right = r
                    };
                    res.Add(root);
                }
            }
        }

        return _dp[n] = res;
    }
}