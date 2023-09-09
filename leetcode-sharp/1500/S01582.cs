namespace leetcode_sharp;

// 1582. Special Positions in a Binary Matrix
// https://leetcode.com/problems/special-positions-in-a-binary-matrix/
public class S01582
{
    public int NumSpecial(int[][] mat)
    {
        var rows = mat.Length;
        var cols = mat[0].Length;
        var rowSum = new int[rows];
        var colSum = new int[cols];
        var res = 0;

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                rowSum[i] += mat[i][j];
                colSum[j] += mat[i][j];
            }
        }

        for (var i = 0; i < rows; i++)
        {
            if (rowSum[i] != 1)
            {
                continue;
            }

            for (var j = 0; j < cols; j++)
            {
                if (mat[i][j] == 1 && colSum[j] == 1)
                {
                    res++;
                }
            }
        }

        return res;
    }
}