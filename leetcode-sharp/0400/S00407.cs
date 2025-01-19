namespace leetcode_sharp;

// 407. Trapping Rain Water II
// https://leetcode.com/problems/trapping-rain-water-ii
public class S00407
{
    public int TrapRainWater(int[][] heightMap)
    {
        var m = heightMap.Length;
        var n = heightMap[0].Length;
        var visited = new bool[m, n];
        PriorityQueue<(int Row, int Col, int Height), int> queue = new();

        // Add borders
        for (var i = 0; i < m; i++)
        {
            visited[i, 0] = true;
            visited[i, n - 1] = true;
            queue.Enqueue((i, 0, heightMap[i][0]), heightMap[i][0]);
            queue.Enqueue((i, n - 1, heightMap[i][n - 1]), heightMap[i][n - 1]);
        }

        for (var i = 0; i < n; i++)
        {
            visited[0, i] = true;
            visited[m - 1, i] = true;
            queue.Enqueue((0, i, heightMap[0][i]), heightMap[0][i]);
            queue.Enqueue((m - 1, i, heightMap[m - 1][i]), heightMap[m - 1][i]);
        }

        var directions = new[] { new[] { -1, 0 }, new[] { 1, 0 }, new[] { 0, -1 }, new[] { 0, 1 } };

        var result = 0;

        while (queue.Count > 0)
        {
            var (row, col, height) = queue.Dequeue();

            foreach (var direction in directions)
            {
                var newRow = row + direction[0];
                var newCol = col + direction[1];

                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && !visited[newRow, newCol])
                {
                    visited[newRow, newCol] = true;
                    result += Math.Max(0, height - heightMap[newRow][newCol]);
                    queue.Enqueue((newRow, newCol, Math.Max(heightMap[newRow][newCol], height)), Math.Max(heightMap[newRow][newCol], height));
                }
            }
        }

        return result;
    }
}
