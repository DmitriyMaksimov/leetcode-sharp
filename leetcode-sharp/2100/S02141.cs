namespace leetcode_sharp;

// 2141. Maximum Running Time of N Computers
// https://leetcode.com/problems/maximum-running-time-of-n-computers/
public class S02141
{
    public long MaxRunTime(int n, int[] batteries)
    {
        var left = 1L;
        var right = batteries.Select(x => (long)x).Sum() / n;

        Array.Sort(batteries);

        while (left < right)
        {
            var mid = left + (right - left + 1) / 2;

            if (possible(n, batteries, mid))
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }

    private static bool possible(int n, int[] batteries, long hours)
    {
        long s = 0;

        foreach (var time in batteries)
        {
            s += time;

            if (s >= hours)
            {
                s -= hours;
                n--;
            }

            if (n == 0)
            {
                return true;
            }
        }

        return false;
    }
}