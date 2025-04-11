namespace leetcode_sharp;

// 1878. Get Biggest Three Rhombus Sums in a Grid
// https://leetcode.com/problems/get-biggest-three-rhombus-sums-in-a-grid
public class S01878
{
    public int[] GetBiggestThree(int[][] grid)
    {
        var minDimension = Math.Min(grid.Length, grid[0].Length);
        var maxThree = new[] { 0, 0, 0 };

        for (var length = 0; length < minDimension; length++)
        {
            SearchBigThree(grid, maxThree, length);
        }

        Array.Sort(maxThree);

        if (maxThree[0] == 0)
        {
            if (maxThree[1] == 0)
            {
                return [maxThree[2]];
            }

            return [maxThree[2], maxThree[1]];
        }

        Array.Reverse(maxThree);
        return maxThree;
    }

    private void SearchBigThree(int[][] grid, int[] maxThree, int length)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var endRow = rows - (length == 0 ? 0 : 2 * length);
        var endCol = cols - length;

        for (var i = 0; i < endRow; i++)
        {
            for (var j = length; j < endCol; j++)
            {
                if (i + j >= length)
                {
                    var sum = GetRhombusSum(grid, i, j, length);
                    AddToMaxThree(maxThree, sum);
                }
            }
        }
    }

    private int GetRhombusSum(int[][] grid, int i, int j, int length)
    {
        if (length == 0)
        {
            return grid[i][j];
        }

        var sum = 0;

        // Edge ab
        for (var d = 0; d <= length; d++)
        {
            sum += grid[i + d][j + d];
        }

        for (var d = 1; d <= length; d++)
        {
            sum += grid[i + d][j - d];
        }

        for (var d = 1; d <= length; d++)
        {
            sum += grid[i + length + d][j - length + d];
        }

        for (var d = 1; d < length; d++)
        {
            sum += grid[i + length + d][j + length - d];
        }

        return sum;
    }

    private void AddToMaxThree(int[] maxThree, int num)
    {
        if (maxThree.Contains(num))
        {
            return;
        }

        Array.Sort(maxThree);

        if (maxThree[0] < num)
        {
            maxThree[0] = num;
        }
    }
}
