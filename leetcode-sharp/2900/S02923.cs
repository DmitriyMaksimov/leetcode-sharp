namespace leetcode_sharp;

// 2923. Find Champion I
// https://leetcode.com/problems/find-champion-i
public class S02923
{
    public int FindChampion(int[][] grid)
    {
        var n = grid.Length;

        for (var i = 0; i < n; i++)
        {
            var found = true;

            for (var j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (grid[i][j] != 1)
                {
                    found = false;
                }
            }

            if (found)
            {
                return i;
            }
        }

        return n - 1;
    }
}