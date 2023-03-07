namespace leetcode_sharp;

// 2187. Minimum Time to Complete Trips
// https://leetcode.com/problems/minimum-time-to-complete-trips/
public class S02187
{
    public long MinimumTime(int[] time, int totalTrips)
    {
        var left = 1L;
        var right = long.MaxValue;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            var trips = 0L;
            
            foreach (var t in time)
            {
                trips += mid / t;
                if (trips >= totalTrips)
                {
                    // To avoid sum overflow
                    break;
                }
            }

            if (trips >= totalTrips)
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