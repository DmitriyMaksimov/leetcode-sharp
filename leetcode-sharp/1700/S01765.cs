namespace leetcode_sharp;

// 1765. Map of Highest Peak
// https://leetcode.com/problems/map-of-highest-peak
public class S01765
{
    public int[][] HighestPeak(int[][] isWater)
    {
        var m = isWater.Length;
        var n = isWater[0].Length;
        Queue<int[]> bfs = [];

        var height = new int[m][];
        for (var i = 0; i < m; i++)
        {
            height[i] = new int[n];
        }

        for (var r = 0; r < m; r++)
        {
            for (var c = 0; c < n; c++)
            {
                if (isWater[r][c] == 1)
                {
                    height[r][c] = 0;
                    bfs.Enqueue([r, c]);
                }
                else
                {
                    height[r][c] = -1;
                }
            }
        }

        int[] directions = [0, 1, 0, -1, 0];

        while (bfs.Count != 0)
        {
            var top = bfs.Dequeue();
            int r = top[0], c = top[1];
            for (var i = 0; i < 4; i++)
            {
                int nr = r + directions[i], nc = c + directions[i + 1];
                if (nr < 0 || nr == m || nc < 0 || nc == n || height[nr][nc] != -1)
                {
                    continue;
                }

                height[nr][nc] = height[r][c] + 1;
                bfs.Enqueue([nr, nc]);
            }
        }

        return height;
    }
}
