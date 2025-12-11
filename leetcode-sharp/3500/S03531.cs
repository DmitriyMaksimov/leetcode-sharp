namespace leetcode_sharp;

// 3531. Count Covered Buildings
// https://leetcode.com/problems/count-covered-buildings
public class S03531
{
    public int CountCoveredBuildings(int n, int[][] buildings)
    {
        var yRangeGivenX = new Dictionary<int, int[]>(); // x -> [minY, maxY]
        var xRangeGivenY = new Dictionary<int, int[]>(); // y -> [minX, maxX]

        foreach (var b in buildings)
        {
            var x = b[0];
            var y = b[1];

            if (!yRangeGivenX.ContainsKey(x))
            {
                yRangeGivenX[x] = [int.MaxValue, int.MinValue];
            }

            yRangeGivenX[x][0] = Math.Min(yRangeGivenX[x][0], y);
            yRangeGivenX[x][1] = Math.Max(yRangeGivenX[x][1], y);

            if (!xRangeGivenY.ContainsKey(y))
            {
                xRangeGivenY[y] = [int.MaxValue, int.MinValue];
            }

            xRangeGivenY[y][0] = Math.Min(xRangeGivenY[y][0], x);
            xRangeGivenY[y][1] = Math.Max(xRangeGivenY[y][1], x);
        }

        var result = 0;

        foreach (var b in buildings)
        {
            var x = b[0];
            var y = b[1];

            if (xRangeGivenY[y][0] < x && x < xRangeGivenY[y][1] && yRangeGivenX[x][0] < y && y < yRangeGivenX[x][1])
            {
                result++;
            }
        }

        return result;
    }
}