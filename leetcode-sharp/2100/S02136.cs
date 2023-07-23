namespace leetcode_sharp;

// 2136. Earliest Possible Day of Full Bloom
// https://leetcode.com/problems/earliest-possible-day-of-full-bloom/
public class S02136
{
    public int EarliestFullBloom(int[] plantTime, int[] growTime)
    {
        var max = growTime.Max();

        var arr = new int[max + 1];
        var tmp = 0;
        var minTime = 0;

        for (var i = 0; i < plantTime.Length; i++)
        {
            arr[growTime[i]] += plantTime[i];
        }

        for (var i = max; i > 0; i--)
        {
            if (arr[i] == 0) continue;
            
            tmp += arr[i];
            minTime = Math.Max(minTime, tmp + i);
        }

        return minTime;
    }
}