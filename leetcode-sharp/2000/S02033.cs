namespace leetcode_sharp;

// 2033. Minimum Operations to Make a Uni-Value Grid
// https://leetcode.com/problems/minimum-operations-to-make-a-uni-value-grid
public class S02033
{
    public int MinOperations(int[][] grid, int x)
    {
        var values = grid.SelectMany(row => row).ToList();

        if (values.Select(val => val % x).Distinct().Count() > 1)
        {
            return -1;
        }

        values.Sort();

        var median = values[values.Count / 2];

        return values.Sum(val => Math.Abs(val - median) / x);
    }
}
