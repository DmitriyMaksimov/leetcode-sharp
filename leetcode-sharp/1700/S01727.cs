namespace leetcode_sharp;

// 1727. Largest Submatrix With Rearrangements
// https://leetcode.com/problems/largest-submatrix-with-rearrangements
public class S01727
{
    public int LargestSubmatrix(int[][] matrix)
    {
        for (var i = 1; i < matrix.Length; i++) //Start from row 1 because row 0 will be unaffected as no row above it.
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0)
                {
                    matrix[i][j] = matrix[i - 1][j] + 1;
                }
            }
        }

        var maxSize = 0;

        foreach (var col in matrix)
        {
            var pq = new PriorityQueue<int, int>();
            foreach (var row in col)
            {
                if (row > 0)
                {
                    pq.Enqueue(row, row);
                }
            }

            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                var size = curr * (pq.Count + 1);
                maxSize = Math.Max(maxSize, size);
            }
        }

        return maxSize;
    }
}