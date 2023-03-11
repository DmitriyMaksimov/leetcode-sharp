namespace leetcode_sharp;

// 740. Delete and Earn
// https://leetcode.com/problems/delete-and-earn/
public class S00740
{
    public int DeleteAndEarn(int[] nums)
    {
        const int maxBuckets = 10001;
        var values = new int[maxBuckets];
        foreach (var num in nums)
        {
            values[num] += num;
        }

        var take = 0;
        var skip = 0;
        for (var i = 0; i < maxBuckets; i++)
        {
            var takei = skip + values[i];
            var skipi = Math.Max(skip, take);
            take = takei;
            skip = skipi;
        }

        return Math.Max(take, skip);
    }
}