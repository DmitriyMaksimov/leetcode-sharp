namespace leetcode_sharp;

// 2022. Convert 1D Array Into 2D Array
// https://leetcode.com/problems/convert-1d-array-into-2d-array/
public class S02022
{
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (original.Length != m * n)
        {
            return [];
        }

        var result = new int[m][];
        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];
            for (var j = 0; j < n; j++)
            {
                result[i][j] = original[i * n + j];
            }
        }

        return result;
    }
}