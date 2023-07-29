namespace leetcode_sharp;

// 463. Island Perimeter
// https://leetcode.com/problems/island-perimeter/
public class S00463
{
    public int IslandPerimeter(int[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var ans = 0;

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (grid[i][j] != 1) continue;
                
                ans += 4;
                if (i > 0 && grid[i - 1][j] == 1) ans -= 2;
                if (j > 0 && grid[i][j - 1] == 1) ans -= 2;
            }
        }

        return ans;
    }
}