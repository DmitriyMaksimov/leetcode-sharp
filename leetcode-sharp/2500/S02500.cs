namespace leetcode_sharp;

// 2500. Delete Greatest Value in Each Row
// https://leetcode.com/problems/delete-greatest-value-in-each-row/
public class S02500
{
    public int DeleteGreatestValue(int[][] grid)
    {
        foreach (var row in grid)
        {
            Array.Sort(row);
        }

        var ans = 0;

        for (var j = 0; j < grid[0].Length; j++)
        {
            ans += grid.Select(row => row[j]).Max();
        }

        return ans;
    }
}