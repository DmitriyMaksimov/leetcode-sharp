namespace leetcode_sharp;

// 542. 01 Matrix
// https://leetcode.com/problems/01-matrix/
public class S00542
{
    private const int Unprocessed = -1;
    private readonly int[] _directions = {0, 1, 0, -1, 0};

    public int[][] UpdateMatrix(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        var queue = new Queue<(int row, int col)>();
        
        for (var row = 0; row < m; ++row)
        {
            for (var col = 0; col < n; ++col)
            {
                if (mat[row][col] == 0)
                {
                    queue.Enqueue((row, col));
                }
                else
                {
                    mat[row][col] = Unprocessed;
                }
            }
        }

        while (queue.Count > 0)
        {
            var (row, col) = queue.Dequeue();
            for (var i = 0; i < 4; ++i)
            {
                var newRow = row + _directions[i];
                var newCol = col + _directions[i + 1];
                if (newRow >= 0 && newRow != m && newCol >= 0 && newCol != n && mat[newRow][newCol] == Unprocessed)
                {
                    mat[newRow][newCol] = mat[row][col] + 1;
                    queue.Enqueue((newRow, newCol));
                }
            }
        }

        return mat;
    }
}