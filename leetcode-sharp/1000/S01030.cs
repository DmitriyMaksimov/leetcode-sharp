namespace leetcode_sharp;

// 1030. Matrix Cells in Distance Order
// https://leetcode.com/problems/matrix-cells-in-distance-order/
public class S01030
{
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
    {
        var visited = new bool[rows, cols];
        var result = new int[rows * cols][];
        var i = 0;
        var queue = new Queue<int[]>();
        queue.Enqueue([rCenter, cCenter]);
        while (queue.Any())
        {
            var cell = queue.Dequeue();
            var r = cell[0];
            var c = cell[1];

            if (r < 0 || r >= rows || c < 0 || c >= cols)
            {
                continue;
            }

            if (visited[r, c])
            {
                continue;
            }

            result[i++] = cell;
            visited[r, c] = true;

            queue.Enqueue([r, c - 1]);
            queue.Enqueue([r, c + 1]);
            queue.Enqueue([r - 1, c]);
            queue.Enqueue([r + 1, c]);
        }

        return result;
    }
}