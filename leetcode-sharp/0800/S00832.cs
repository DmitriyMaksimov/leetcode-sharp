namespace leetcode_sharp;

// 832. Flipping an Image
// https://leetcode.com/problems/flipping-an-image/
public class S00832
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        var n = image.Length;
        var m = image[0].Length;

        for (var row = 0; row < n; row++)
        {
            for (var col = 0; col < m / 2; col++)
            {
                var rightIndex = ^(col + 1);
                (image[row][col], image[row][rightIndex]) = (image[row][rightIndex], image[row][col]);
            }
        }

        for (var row = 0; row < n; row++)
        {
            for (var col = 0; col < m; col++)
            {
                image[row][col] = image[row][col] == 1 ? 0 : 1;
            }
        }

        return image;
    }
}