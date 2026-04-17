namespace leetcode_sharp;

// 3761. Minimum Absolute Distance Between Mirror Pairs
// https://leetcode.com/problems/minimum-absolute-distance-between-mirror-pairs
public class S03761
{
    public int MinMirrorPairDistance(int[] nums)
    {
        var result = int.MaxValue;
        var seen = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var n = nums[i];

            if (seen.TryGetValue(n, out var prevIndex))
            {
                result = Math.Min(result, i - prevIndex);
            }

            var reversed = ReverseNumber(n);
            seen[reversed] = i;
        }

        return result == int.MaxValue ? -1 : result;
    }

    private static int ReverseNumber(int n)
    {
        var reversed = 0;

        while (n > 0)
        {
            reversed = reversed * 10 + (n % 10);
            n /= 10;
        }

        return reversed;
    }
}