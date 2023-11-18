namespace leetcode_sharp;

// 2873. Maximum Value of an Ordered Triplet I
// https://leetcode.com/problems/maximum-value-of-an-ordered-triplet-i
public class S02873
{
    public long MaximumTripletValue(int[] nums)
    {
        var result = 0L;
        var maxI = 0L;
        var maxIj = 0L;

        foreach (var num in nums)
        {
            result = Math.Max(result, 1L * maxIj * num);
            maxIj = Math.Max(maxIj, maxI - num);
            maxI = Math.Max(maxI, num);
        }

        return result;
    }
}