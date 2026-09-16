namespace leetcode_sharp;

// 1621. Number of Sets of K Non-Overlapping Line Segments
// https://leetcode.com/problems/number-of-sets-of-k-non-overlapping-line-segments
public class S01621
{
    private int?[][][] _memo = null!;
    private int _n;

    public int NumberOfSets(int n, int k)
    {
        this._n = n;
        this._memo = new int?[n + 1][][];
        for (var i = 0; i <= n; i++)
        {
            this._memo[i] = new int?[k + 1][];
            for (var j = 0; j <= k; j++)
            {
                this._memo[i][j] = new int?[2];
            }
        }

        return Dp(0, k, 1);
    }

    private int Dp(int i, int k, int isStart)
    {
        if (_memo[i][k][isStart].HasValue)
        {
            return _memo[i][k][isStart]!.Value;
        }

        if (k == 0)
        {
            return 1;
        }

        if (i == _n)
        {
            return 0;
        }

        var result = Dp(i + 1, k, isStart);

        if (isStart == 1)
        {
            result += Dp(i + 1, k, 0);
        }
        else
        {
            result += Dp(i, k - 1, 1);
        }

        return (int)(_memo[i][k][isStart] = result % 1_000_000_007);
    }
}