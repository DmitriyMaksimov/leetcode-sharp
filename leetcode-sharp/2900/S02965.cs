namespace leetcode_sharp;

// 2965. Find Missing and Repeated Values
// https://leetcode.com/problems/find-missing-and-repeated-values
public class S02965
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        var n = grid.Length;
        var a = 0;
        var b = 0;
        var dictionary = new Dictionary<int, int>();

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                dictionary[grid[i][j]] = dictionary.GetValueOrDefault(grid[i][j]) + 1;
            }
        }

        for (var i = 1; i <= n * n; i++)
        {
            if (!dictionary.ContainsKey(i))
            {
                b = i;
            }
            else if (dictionary[i] == 2)
            {
                a = i;
            }
        }

        return new[] {a, b};
    }
}