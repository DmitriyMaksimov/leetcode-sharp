namespace leetcode_sharp;

// 164. Maximum Gap
// https://leetcode.com/problems/maximum-gap
public class S00164
{
    public int MaximumGap(int[] nums)
    {
        if (nums.Length < 2)
        {
            return 0;
        }

        var min = nums.Min();
        var max = nums.Max();

        if (min == max)
        {
            return 0;
        }

        var n = nums.Length;
        var bucketSize = (int)Math.Ceiling((double)(max - min) / (n - 1));
        var minBucket = Enumerable.Repeat(int.MaxValue, n).ToArray();
        var maxBucket = Enumerable.Repeat(int.MinValue, n).ToArray();

        foreach (var x in nums)
        {
            var idx = (x - min) / bucketSize;
            minBucket[idx] = Math.Min(x, minBucket[idx]);
            maxBucket[idx] = Math.Max(x, maxBucket[idx]);
        }

        var result = bucketSize;
        var previous = maxBucket[0];

        for (var i = 1; i < n; i++)
        {
            if (minBucket[i] == int.MaxValue)
            {
                continue;
            }

            result = Math.Max(result, minBucket[i] - previous);
            previous = maxBucket[i];
        }

        return result;
    }
}
