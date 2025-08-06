namespace leetcode_sharp;

// 3128. Right Triangles
// https://leetcode.com/problems/right-triangles
public class S03128
{
    public long NumberOfRightTriangles(int[][] grid)
    {
        var rowCount = grid.Length;
        var colCount = grid[0].Length;

        var rowOnes = new int[rowCount];
        var colOnes = new int[colCount];

        for (var i = 0; i < rowCount; i++)
        {
            rowOnes[i] = grid[i].Count(cell => cell == 1);
        }

        for (var j = 0; j < colCount; j++)
        {
            var count = 0;
            for (var i = 0; i < rowCount; i++)
            {
                if (grid[i][j] == 1)
                {
                    count++;
                }
            }

            colOnes[j] = count;
        }

        var totalTriangles = 0L;

        for (var i = 0; i < rowCount; i++)
        {
            for (var j = 0; j < colCount; j++)
            {
                if (grid[i][j] == 1)
                {
                    long rowContribution = rowOnes[i] - 1;
                    long colContribution = colOnes[j] - 1;
                    totalTriangles += rowContribution * colContribution;
                }
            }
        }

        return totalTriangles;
    }
}