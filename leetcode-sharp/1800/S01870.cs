namespace leetcode_sharp;

// 1870. Minimum Speed to Arrive on Time
// https://leetcode.com/problems/minimum-speed-to-arrive-on-time/
public class S01870
{
    public int MinSpeedOnTime(int[] dist, double hour)
    {
        var n = dist.Length;
        if (hour <= n - 1)
        {
            return -1;
        }

        var left = 1;
        var right = 10_000_000;

        while (left < right)
        {
            var mid = left + (right - left) / 2;
        
            double time = 0;
            
            for (var i = 0; i < n - 1; i++)
            {
                time += Math.Ceiling((double) dist[i] / mid);
            }

            time += (double) dist[n - 1] / mid;

            if (time <= hour)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}