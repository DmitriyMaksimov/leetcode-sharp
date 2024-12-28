namespace leetcode_sharp;

// 2274. Maximum Consecutive Floors Without Special Floors
// https://leetcode.com/problems/maximum-consecutive-floors-without-special-floors
public class S02274
{
    public int MaxConsecutive(int bottom, int top, int[] special)
    {
        Array.Sort(special);

        var result = Math.Max(special[0] - bottom, top - special[^1]);

        for (var i = 0; i < special.Length - 1; ++i)
        {
            result = Math.Max(result, special[i + 1] - special[i] - 1);
        }

        return result;
    }
}
