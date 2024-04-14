namespace leetcode_sharp;

// 1706. Where Will the Ball Fall
// https://leetcode.com/problems/where-will-the-ball-fall
public class S01706
{
    public int[] FindBall(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var result = new int[n];

        for (var i = 0; i < n; ++i)
        {
            var current = i;
            
            for (var j = 0; j < m; ++j)
            {
                var next = current + grid[j][current];
            
                if (next < 0 || next >= n || grid[j][next] != grid[j][current])
                {
                    current = -1;
                    break;
                }

                current = next;
            }

            result[i] = current;
        }

        return result;
    }
}