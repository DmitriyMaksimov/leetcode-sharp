namespace leetcode_sharp;

// 3546. Equal Sum Grid Partition I
// https://leetcode.com/problems/equal-sum-grid-partition-i
public class S03546
{
    public bool CanPartitionGrid(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var total = 0L;

        foreach (var row in grid)
        {
            foreach (var val in row)
            {
                total += val;
            }
        }

        if ((total & 1) == 1)
        {
            return false;
        }

        var half = total / 2;
        var prefix = 0L;

        for (var i = 0; i < m - 1; i++)
        {
            foreach (var val in grid[i])
            {
                prefix += val;
            }

            if (prefix == half)
            {
                return true;
            }
        }

        prefix = 0;

        for (var j = 0; j < n - 1; j++)
        {
            for (var i = 0; i < m; i++)
            {
                prefix += grid[i][j];
            }

            if (prefix == half)
            {
                return true;
            }
        }

        return false;
    }
}