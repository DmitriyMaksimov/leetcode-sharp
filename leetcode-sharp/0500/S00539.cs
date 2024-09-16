namespace leetcode_sharp;

// 539. Minimum Time Difference
// https://leetcode.com/problems/minimum-time-difference
public class S00539
{
    public int FindMinDifference(IList<string> timePoints)
    {
        var n = timePoints.Count;
        var counts = new int[n];

        for (var i = 0; i < n; i++)
        {
            var s = timePoints[i];
            counts[i] = int.Parse(s[..2]) * 60 + int.Parse(s[3..5]);
        }

        Array.Sort(counts);

        var result = int.MaxValue;

        for (var i = 0; i < n - 1; i++)
        {
            result = Math.Min(result, counts[i + 1] - counts[i]);
        }

        result = Math.Min(result, counts[0] + (24 * 60 - counts[n - 1]));
        return result;
    }
}
