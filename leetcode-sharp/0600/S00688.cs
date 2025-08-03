namespace leetcode_sharp;

// 688. Knight Probability in Chessboard
// https://leetcode.com/problems/knight-probability-in-chessboard/
public class S00688
{
    private double[,,] _dp;
    private readonly (int x, int y)[] _moves = [(-2, -1), (-2, 1), (-1, -2), (-1, 2), (1, -2), (1, 2), (2, -1), (2, 1)];

    public double KnightProbability(int n, int k, int row, int col)
    {
        initDp(n, k);

        return dfs(row, col, n, k) / Math.Pow(8, k);
    }

    private void initDp(int n, int k)
    {
        _dp = new double[n, n, k + 1];
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                for (var l = 0; l < k + 1; l++)
                {
                    _dp[i, j, l] = -1;
                }
            }
        }
    }

    private double dfs(int row, int col, int n, int k)
    {
        if (row < 0 || col < 0 || row >= n || col >= n)
        {
            return 0;
        }

        if (k == 0)
        {
            return 1;
        }

        if (_dp[row, col, k] != -1.0)
        {
            return _dp[row, col, k];
        }

        double ans = 0;

        foreach (var (x, y) in _moves)
        {
            ans += dfs(row + x, col + y, n, k - 1);
        }

        return _dp[row, col, k] = ans;
    }
}