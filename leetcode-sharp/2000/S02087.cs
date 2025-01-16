namespace leetcode_sharp;

// 2087. Minimum Cost Homecoming of a Robot in a Grid
// https://leetcode.com/problems/minimum-cost-homecoming-of-a-robot-in-a-grid
public class S02087
{
    public int MinCost(int[] startPos, int[] homePos, int[] rowCosts, int[] colCosts)
    {
        var result = 0;
        var startRow = startPos[0];
        var startCol = startPos[1];
        var homeRow = homePos[0];
        var homeCol = homePos[1];

        while (startRow != homeRow)
        {
            startRow += (homeRow - startRow) / Math.Abs(homeRow - startRow);
            result += rowCosts[startRow];
        }

        while (startCol != homeCol)
        {
            startCol += (homeCol - startCol) / Math.Abs(homeCol - startCol);
            result += colCosts[startCol];
        }

        return result;
    }
}
