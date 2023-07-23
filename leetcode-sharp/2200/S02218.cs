namespace leetcode_sharp;

// 2218. Maximum Value of K Coins From Piles
// https://leetcode.com/problems/maximum-value-of-k-coins-from-piles/
public class S02218
{
    private Dictionary<(int, int), int> _dp = new();

    public int MaxValueOfCoins(IList<IList<int>> piles, int k)
    {
        return dp(piles, 0, k);
    }

    private int dp(IList<IList<int>> piles, int i, int k)
    {
        if (k == 0 || i == piles.Count)
        {
            return 0;
        }

        if (_dp.ContainsKey((i, k)))
        {
            return _dp[(i, k)];
        }

        var res = dp(piles, i + 1, k);
        var cur = 0;

        for (var j = 0; j < Math.Min(piles[i].Count(), k); ++j)
        {
            cur += piles[i][j];
            res = Math.Max(res, cur + dp(piles, i + 1, k - j - 1));
        }

        return _dp[(i, k)] = res;
    }
}