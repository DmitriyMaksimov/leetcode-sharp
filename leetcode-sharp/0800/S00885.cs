namespace leetcode_sharp;

// 885. Spiral Matrix III
// https://leetcode.com/problems/spiral-matrix-iii
public class S00885
{
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
    {
        var res = new int[rows * cols][];

        for (var i = 0; i < res.Length; i++)
        {
            res[i] = new int[2];
        }
        
        var dx = 0;
        var dy = 1;
        var n = 0;

        for (var j = 0; j < rows * cols; ++n)
        {
            for (var i = 0; i < n / 2 + 1; ++i)
            {
                if (0 <= rStart && rStart < rows && 0 <= cStart && cStart < cols)
                {
                    res[j++] = [rStart, cStart];
                }

                rStart += dx;
                cStart += dy;
            }

            var tmp = dx;
            dx = dy;
            dy = -tmp;
        }

        return res;
    }
}