namespace leetcode_sharp;

// 2596. Check Knight Tour Configuration
// https://leetcode.com/problems/check-knight-tour-configuration
public class S02596
{
    public bool CheckValidGrid(int[][] grid)
    {
        if (grid[0][0] != 0)
        {
            return false;
        }

        var n = grid.Length;
        var positions = new (int, int)[n * n];

        for (var x = 0; x < n; ++x)
        {
            for (var y = 0; y < n; ++y)
            {
                positions[grid[x][y]] = (x, y);
            }
        }

        for (var i = 1; i < n * n; ++i)
        {
            var dx = Math.Abs(positions[i].Item1 - positions[i - 1].Item1);
            var dy = Math.Abs(positions[i].Item2 - positions[i - 1].Item2);

            if (dx * dy != 2)
            {
                return false;
            }
        }

        return true;
    }
}
