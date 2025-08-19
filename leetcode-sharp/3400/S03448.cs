namespace leetcode_sharp;

// 3648. Minimum Sensors to Cover Grid
// https://leetcode.com/problems/minimum-sensors-to-cover-grid
public class S03448
{
    public int MinSensors(int n, int m, int k)
    {
        var side = 2 * k + 1;
        long rows = (n + side - 1) / side;
        long cols = (m + side - 1) / side;

        return (int)(rows * cols);
    }
}