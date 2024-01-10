namespace leetcode_sharp;

// 3000. Maximum Area of Longest Diagonal Rectangle
// https://leetcode.com/problems/maximum-area-of-longest-diagonal-rectangle
public class S03000
{
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
        var maxArea = -1;
        var maxDiagonal = -1L;

        foreach (var dimension in dimensions)
        {
            var length = dimension[0];
            var width = dimension[1];
            long diagonal = length * length + width * width;

            if (diagonal > maxDiagonal)
            {
                maxDiagonal = diagonal;
                maxArea = length * width;
            }
            else if (diagonal == maxDiagonal)
            {
                maxArea = Math.Max(maxArea, length * width);
            }
        }

        return maxArea;
    }
}