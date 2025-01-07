namespace leetcode_sharp;

// 3212. Count Submatrices With Equal Frequency of X and Y
// https://leetcode.com/problems/count-submatrices-with-equal-frequency-of-x-and-y
public class S03212
{
    public int NumberOfSubmatrices(char[][] grid)
    {
        var xCount = CalculateSum(grid, 'X');
        var yCount = CalculateSum(grid, 'Y');

        var result = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (xCount[i][j] == yCount[i][j] && xCount[i][j] > 0)
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static int[][] CalculateSum(char[][] grid, char ch)
    {
        var n = grid.Length;
        var m = grid[0].Length;
        var prefixSum = new int[n][];

        for (var i = 0; i < n; i++)
        {
            prefixSum[i] = new int[m];
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                prefixSum[i][j] = grid[i][j] == ch ? 1 : 0;
                if (i > 0)
                {
                    prefixSum[i][j] += prefixSum[i - 1][j];
                }

                if (j > 0)
                {
                    prefixSum[i][j] += prefixSum[i][j - 1];
                }

                if (i > 0 && j > 0)
                {
                    prefixSum[i][j] -= prefixSum[i - 1][j - 1];
                }
            }
        }

        return prefixSum;
    }
}
