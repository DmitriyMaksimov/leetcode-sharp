namespace leetcode_sharp;

// 2267. Check if There Is a Valid Parentheses String Path
// https://leetcode.com/problems/check-if-there-is-a-valid-parentheses-string-path
public class S02267
{
    private int _n;
    private int _m;
    private int[,,] _dp = null!;

    public bool HasValidPath(char[][] grid)
    {
        _n = grid.Length;
        _m = grid[0].Length;

        _dp = new int[_n, _m, 205];

        // Fill the entire array with -1
        for (var i = 0; i < _n; i++)
        {
            for (var j = 0; j < _m; j++)
            {
                for (var k = 0; k < 205; k++)
                {
                    _dp[i, j, k] = -1;
                }
            }
        }

        return CanReachValidPath(grid, 0, 0, 0);
    }

    private bool CanReachValidPath(char[][] grid, int i, int j, int k)
    {
        if (i >= _n || j >= _m)
        {
            return false;
        }

        if (grid[i][j] == '(')
        {
            k++;
        }
        else
        {
            k--;
        }

        if (k < 0)
        {
            return false;
        }

        if (i == _n - 1 && j == _m - 1)
        {
            return k == 0;
        }

        if (_dp[i, j, k] != -1)
        {
            return _dp[i, j, k] == 1;
        }

        var result = CanReachValidPath(grid, i + 1, j, k) || CanReachValidPath(grid, i, j + 1, k);

        _dp[i, j, k] = result ? 1 : 0;

        return result;
    }
}