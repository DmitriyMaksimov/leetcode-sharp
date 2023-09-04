namespace leetcode_sharp;

// 883. Projection Area of 3D Shapes
// https://leetcode.com/problems/projection-area-of-3d-shapes/
public class S00883
{
    public int ProjectionArea(int[][] grid)
    {
        var xy = 0;
        var xz = 0;
        var yz = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            var maxRow = 0;
            var maxCol = 0;
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] > 0)
                {
                    xy++;
                }

                maxRow = Math.Max(maxRow, grid[i][j]);
                maxCol = Math.Max(maxCol, grid[j][i]);
            }

            xz += maxRow;
            yz += maxCol;
        }

        return xy + xz + yz;
    }
}