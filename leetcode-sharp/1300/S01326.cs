namespace leetcode_sharp;

// 1326. Minimum Number of Taps to Open to Water a Garden
// https://leetcode.com/problems/minimum-number-of-taps-to-open-to-water-a-garden/ 
public class S01326
{
    public int MinTaps(int n, int[] ranges)
    {
        var arr = new int[n + 1];

        for (var i = 0; i < ranges.Length; i++)
        {
            if (ranges[i] == 0)
            {
                continue;
            }

            var left = Math.Max(0, i - ranges[i]);
            arr[left] = Math.Max(arr[left], i + ranges[i]);
        }

        var end = 0;
        var farCanReach = 0;
        var cnt = 0;
        
        for (var i = 0; i <= n; i++)
        {
            if (i > end)
            {
                if (farCanReach <= end)
                {
                    return -1;
                }

                end = farCanReach;
                cnt++;
            }

            farCanReach = Math.Max(farCanReach, arr[i]);
        }

        return cnt + (end < n ? 1 : 0);
    }
}