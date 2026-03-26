namespace leetcode_sharp;

// 3548. Equal Sum Grid Partition II
// https://leetcode.com/problems/equal-sum-grid-partition-ii
public class S03548
{
    public bool CanPartitionGrid(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        long total = 0;

        var bottom = new Dictionary<long, int>();
        var top = new Dictionary<long, int>();
        var left = new Dictionary<long, int>();
        var right = new Dictionary<long, int>();

        foreach (var row in grid)
        {
            foreach (var x in row)
            {
                total += x;
                Increment(bottom, x);
                Increment(right, x);
            }
        }

        long sumTop = 0;

        for (var i = 0; i < m - 1; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var val = grid[i][j];
                sumTop += val;

                Increment(top, val);
                Decrement(bottom, val);
            }

            var sumBottom = total - sumTop;

            if (sumTop == sumBottom)
            {
                return true;
            }

            var diff = Math.Abs(sumTop - sumBottom);

            if (sumTop > sumBottom)
            {
                if (Check(top, grid, 0, i, 0, n - 1, diff))
                {
                    return true;
                }
            }
            else
            {
                if (Check(bottom, grid, i + 1, m - 1, 0, n - 1, diff))
                {
                    return true;
                }
            }
        }

        long sumLeft = 0;

        for (var j = 0; j < n - 1; j++)
        {
            for (var i = 0; i < m; i++)
            {
                var val = grid[i][j];
                sumLeft += val;

                Increment(left, val);
                Decrement(right, val);
            }

            var sumRight = total - sumLeft;

            if (sumLeft == sumRight)
            {
                return true;
            }

            var diff = Math.Abs(sumLeft - sumRight);

            if (sumLeft > sumRight)
            {
                if (Check(left, grid, 0, m - 1, 0, j, diff))
                {
                    return true;
                }
            }
            else
            {
                if (Check(right, grid, 0, m - 1, j + 1, n - 1, diff))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool Check(Dictionary<long, int> map, int[][] grid,
        int r1, int r2, int c1, int c2, long diff)
    {
        var rows = r2 - r1 + 1;
        var cols = c2 - c1 + 1;

        if (rows * cols == 1)
        {
            return false;
        }

        if (rows == 1)
        {
            return grid[r1][c1] == diff || grid[r1][c2] == diff;
        }

        if (cols == 1)
        {
            return grid[r1][c1] == diff || grid[r2][c1] == diff;
        }

        return map.TryGetValue(diff, out var count) && count > 0;
    }

    private void Increment(Dictionary<long, int> dict, long key)
    {
        if (dict.TryGetValue(key, out var count))
        {
            dict[key] = count + 1;
        }
        else
        {
            dict[key] = 1;
        }
    }

    private void Decrement(Dictionary<long, int> dict, long key)
    {
        if (dict.TryGetValue(key, out var count))
        {
            if (count == 1)
            {
                dict.Remove(key);
            }
            else
            {
                dict[key] = count - 1;
            }
        }
    }
}