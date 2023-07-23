namespace leetcode_sharp;

// 2373. Largest Local Values in a Matrix
// https://leetcode.com/problems/largest-local-values-in-a-matrix/
public class S02373
{
    public int[][] LargestLocal(int[][] grid)
    {
        var n = grid.Length;
        var result = new int[n - 2][];

        for (var i = 0; i < n - 2; i++)
        {
            result[i] = new int[n - 2];
            for (var j = 0; j < n - 2; j++)
            {
                result[i][j] = findMax(i, j, grid);
            }
        }

        return result;
    }

    private static int findMax(int x, int y, int[][] grid)
    {
        var max = int.MinValue;
        
        for (var i = x; i < x + 3; i++)
        {
            for (var j = y; j < y + 3; j++)
            {
                if (max < grid[i][j])
                {
                    max = grid[i][j];
                }
            }
        }

        return max;
    }
}