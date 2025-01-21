namespace leetcode_sharp;

// 2017. Grid Game
// https://leetcode.com/problems/grid-game/
public class S02017
{
    public long GridGame(int[][] grid)
    {
        var top = grid[0].Sum(x => (long)x);
        long bottom = 0;
        var res = long.MaxValue;

        for (var i = 0; i < grid[0].Length; ++i)
        {
            top -= grid[0][i];
            res = Math.Min(res, Math.Max(top, bottom));
            bottom += grid[1][i];
        }

        return res;
    }
}
