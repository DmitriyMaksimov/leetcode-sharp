namespace leetcode_sharp;

// 1401. Circle and Rectangle Overlapping
// https://leetcode.com/problems/circle-and-rectangle-overlapping
public class S01401
{
    public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
    {
        x1 -= xCenter;
        x2 -= xCenter;
        y1 -= yCenter;
        y2 -= yCenter;

        int minX = x1 * x2 > 0 ? Math.Min(x1 * x1, x2 * x2) : 0, minY = y1 * y2 > 0 ? Math.Min(y1 * y1, y2 * y2) : 0;

        return minY + minX <= radius * radius;
    }
}
