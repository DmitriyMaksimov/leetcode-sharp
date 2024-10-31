namespace leetcode_sharp;

// 3070. Count Submatrices with Top-Left Element and Sum Less Than k
// https://leetcode.com/problems/count-submatrices-with-top-left-element-and-sum-less-than-k
public class S03070
{
    public int CountSubmatrices(int[][] grid, int k)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var result = 0;

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (i > 0)
                {
                    grid[i][j] += grid[i - 1][j];
                }

                if (j > 0)
                {
                    grid[i][j] += grid[i][j - 1];
                }

                if (i > 0 && j > 0)
                {
                    grid[i][j] -= grid[i - 1][j - 1];
                }

                if (grid[i][j] <= k)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
        }

        return result;
    }
}
