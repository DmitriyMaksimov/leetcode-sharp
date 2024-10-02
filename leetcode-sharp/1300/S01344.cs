namespace leetcode_sharp;

// 856. Score of Parentheses
// https://leetcode.com/problems/angle-between-hands-of-a-clock/
public class S01344
{
    public double AngleClock(int hour, int minutes)
    {
        var h = hour % 12 * 30 + (double)minutes / 60 * 30;
        var m = minutes * 6.0;
        var angle = Math.Abs(m - h);

        if (angle > 180)
        {
            angle = 360.0 - angle;
        }

        return angle;
    }
}
