namespace leetcode_sharp;

// 2428. Maximum Sum of an Hourglass
// https://leetcode.com/problems/maximum-sum-of-an-hourglass
public class S02428
{
    public int MaxSum(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var result = 0;

        for (var i = 0; i < m - 2; ++i)
        {
            for (var j = 0; j < n - 2; ++j)
            {
                var row1 = grid[i + 0];
                var row2 = grid[i + 1];
                var row3 = grid[i + 2];
                
                result = Math.Max(result, 
                    row1[j] + row1[j + 1] + row1[j + 2] +
                    row2[j + 1] +
                    row3[j] + row3[j + 1] + row3[j + 2]
                );
            }
        }

        return result;
    }
}