namespace leetcode_sharp;

// 2352. Equal Row and Column Pairs
// https://leetcode.com/problems/equal-row-and-column-pairs/
public class S02352
{
    public int EqualPairs(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var hash = new Dictionary<string, int>();

        for (var row = 0; row < n; ++row)
        {
            var str = "";
            for (var col = 0; col < m; ++col)
            {
                str += $"{grid[col][row]}.";
            }

            hash[str] = hash.GetValueOrDefault(str, 0) + 1;
        }

        var result = 0;

        for (var col = 0; col < m; ++col)
        {
            var str = "";

            for (var row = 0; row < n; ++row)
            {
                str += $"{grid[col][row]}.";
            }

            result += hash.GetValueOrDefault(str, 0);
        }

        return result;
    }
}