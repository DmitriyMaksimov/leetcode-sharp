namespace leetcode_sharp;

// 3296. Minimum Number of Seconds to Make Mountain Height Zero
// https://leetcode.com/problems/minimum-number-of-seconds-to-make-mountain-height-zero
public class S03296
{
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
    {
        var lo = 1L;
        var hi = long.MaxValue;

        while (lo < hi)
        {
            var mid = (lo + hi) >> 1;
            var total = 0L;
            for (var i = 0; i < workerTimes.Length && total < mountainHeight; i++)
            {
                total += (long)(Math.Sqrt((double)mid / workerTimes[i] * 2 + 0.25) - 0.5);
            }

            if (total >= mountainHeight)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }

        return lo;
    }
}