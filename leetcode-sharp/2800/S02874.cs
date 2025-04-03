namespace leetcode_sharp;

// 2874. Maximum Value of an Ordered Triplet II
// https://leetcode.com/problems/maximum-value-of-an-ordered-triplet-ii
public class S02874
{
    public long MaximumTripletValue(int[] nums)
    {
        var highest = 0L;
        var highestDiff = 0L;
        var result = 0L;

        foreach (var num in nums)
        {
            result = Math.Max(result, highestDiff * num);
            highestDiff = Math.Max(highestDiff, highest - num);
            highest = Math.Max(highest, num);
        }

        return result;
    }
}
