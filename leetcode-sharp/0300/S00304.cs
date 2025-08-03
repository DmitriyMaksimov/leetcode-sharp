namespace UnitTests;

// 304. Range Sum Query 2D - Immutable
// https://leetcode.com/problems/range-sum-query-2d-immutable/
public class S00304
{
    public class NumMatrix
    {
        private readonly int[,] _dp = null!;

        public NumMatrix(int[][]? matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return;
            }

            var m = matrix.Length;
            var n = matrix[0].Length;

            _dp = new int[m + 1, n + 1];
            
            for (var i = 1; i <= m; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    _dp[i, j] = _dp[i - 1, j] + _dp[i, j - 1] - _dp[i - 1, j - 1] + matrix[i - 1][j - 1];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            return _dp[row2 + 1, col2 + 1] - _dp[row2 + 1, col1] - _dp[row1, col2 + 1] + _dp[row1, col1];    
        }
    }
}