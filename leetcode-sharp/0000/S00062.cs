namespace leetcode_sharp;

// 62. Unique Paths
// https://leetcode.com/problems/unique-paths/
public class S00062
{
    public int UniquePaths(int m, int n)
    {
        if (m == 1 && n == 1)
        {
            return 1;
        }
        
        var grid = new int[m, n];

        for (var i = 0; i < n; i++)
        {
            grid[m - 1, i] = 1;
        }

        for (var i = 0; i < m; i++)
        {
            grid[i, n - 1] = 1;
        }

        for (var x = m - 1 - 1; x >= 0; x--)
        {
            for (var y = n - 1 - 1; y >= 0; y--)
            {
                grid[x, y] = grid[x + 1, y] + grid[x, y + 1];
            }
        }
        
        return grid[0, 0];
    }
}