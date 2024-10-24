namespace leetcode_sharp;

// 1267. Count Servers that Communicate
// https://leetcode.com/problems/count-servers-that-communicate
public class S01267
{
    public int CountServers(int[][] grid)
    {
        var rows = new int[grid.Length];
        var columns = new int[grid[0].Length];

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    rows[i]++;
                    columns[j]++;
                }
            }
        }

        var result = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1 && (columns[j] > 1 || rows[i] > 1))
                {
                    result++;
                }
            }
        }

        return result;
    }
}
