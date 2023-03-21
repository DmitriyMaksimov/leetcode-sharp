namespace leetcode_sharp;

// 63. Unique Paths II
// https://leetcode.com/problems/unique-paths-ii/
public class S00063
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        var m = obstacleGrid.Length;
        var n = obstacleGrid[0].Length;

        if (obstacleGrid[m - 1][n - 1] == 1)
        {
            return 0;
        }

        if (m == 1 && n == 1)
        {
            return 1;
        }
        
        var grid = new int[m, n];

        grid[m - 1, n - 1] = 0;

        var foundObstacle = false;
        
        for (var i = n - 1; i >= 0; i--)
        {
            foundObstacle |= obstacleGrid[m - 1][i] == 1;
            grid[m - 1, i] =  foundObstacle ? 0 : 1;
        }

        foundObstacle = false;
        
        for (var i = m - 1; i >= 0; i--)
        {
            foundObstacle |= obstacleGrid[i][n - 1] == 1;
            grid[i, n - 1] = foundObstacle ? 0 : 1;
        }

        for (var x = m - 1 - 1; x >= 0; x--)
        {
            for (var y = n - 1 - 1; y >= 0; y--)
            {
                grid[x, y] = obstacleGrid[x][y] == 1 ? 0 : grid[x + 1, y] + grid[x, y + 1];
            }
        }
        
        return grid[0, 0];
    }
}