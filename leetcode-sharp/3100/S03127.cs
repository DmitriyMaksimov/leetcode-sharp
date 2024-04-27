namespace leetcode_sharp;

// 3127. Make a Square with the Same Color
// https://leetcode.com/problems/make-a-square-with-the-same-color
public class S03127
{
    public bool CanMakeSquare(char[][] grid)
    {
        for (var row = 0; row < 2; row++)
        {
            for (var col = 0; col < 2; col++)
            {
                var count = 0;
                if (grid[row][col] != grid[row + 1][col])
                {
                    count++;
                }

                if (grid[row][col] != grid[row][col + 1])
                {
                    count++;
                }

                if (grid[row][col] != grid[row + 1][col + 1])
                {
                    count++;
                }

                if (count is <= 1 or 3)
                {
                    return true;
                }
            }
        }

        return false;
    }
}