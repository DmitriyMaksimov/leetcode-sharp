namespace leetcode_sharp;

// 661. Image Smoother
// https://leetcode.com/problems/image-smoother/
public class S00661
{
    public int[][] ImageSmoother(int[][] img)
    {
        var n = img.Length;
        var m = img[0].Length;
        var result = new int[n][];

        for (var i = 0; i < n; i++)
        {
            result[i] = new int[m];

            for (var j = 0; j < m; j++)
            {
                var amount = 0;
                var count = 0;
                for (var k = Math.Max(i - 1, 0); k <= Math.Min(i + 1, n - 1); k++)
                {
                    for (var l = Math.Max(j - 1, 0); l <= Math.Min(j + 1, m - 1); l++)
                    {
                        count++;
                        amount += img[k][l];
                    }
                }

                result[i][j] = amount / count;
            }
        }

        return result;
    }
}