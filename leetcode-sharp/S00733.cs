namespace leetcode_sharp;

// 733. Flood Fill
// https://leetcode.com/problems/flood-fill/
public class S00733
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        var srcColor = image[sr][sc];
        fill(image, sr, sc, srcColor, color);
        return image;
    }

    private void fill(int[][] image, int row, int col, int srcColor, int color)
    {
        if (image[row][col] != srcColor || image[row][col] == color)
        {
            return;
        }

        image[row][col] = color;
        
        if (col > 0)
        {
            fill(image, row, col - 1, srcColor, color);
        }

        if (col < image[0].Length - 1)
        {
            fill(image, row, col + 1, srcColor, color);
        }

        if (row > 0)
        {
            fill(image, row - 1, col, srcColor, color);
        }

        if (row < image.Length - 1)
        {
            fill(image, row + 1, col, srcColor, color);
        }
    }
}