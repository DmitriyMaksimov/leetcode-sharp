namespace leetcode_sharp;

// 2946. Matrix Similarity After Cyclic Shifts
// https://leetcode.com/problems/matrix-similarity-after-cyclic-shifts
public class S02946
{
    public bool AreSimilar(int[][] mat, int k)
    {
        var (rows, cols) = (mat.Length, mat[0].Length);

        k %= cols;

        if (k == 0)
        {
            return true;
        }

        for (var row = 0; row < rows; row++)
        {
            var c1 = row % 2 == 1 ? cols - k : k;

            for (var col = 0; col < cols; col++, c1 = (c1 + 1) % cols)
            {
                if (mat[row][col] != mat[row][c1])
                {
                    return false;
                }
            }
        }

        return true;
    }
}