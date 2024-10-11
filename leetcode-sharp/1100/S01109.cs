namespace leetcode_sharp;

// 1109. Corporate Flight Bookings
// https://leetcode.com/problems/corporate-flight-bookings
public class S01109
{
    public int[] CorpFlightBookings(int[][] bookings, int n)
    {
        var res = new int[n];

        foreach (var booking in bookings)
        {
            res[booking[0] - 1] += booking[2];

            if (booking[1] < n)
            {
                res[booking[1]] -= booking[2];
            }
        }

        for (var i = 1; i < n; ++i)
        {
            res[i] += res[i - 1];
        }

        return res;
    }
}
