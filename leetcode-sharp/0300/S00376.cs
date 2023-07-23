namespace leetcode_sharp;

// 376. Wiggle Subsequence
// https://leetcode.com/problems/wiggle-subsequence/
public class S00376
{
    public int WiggleMaxLength(int[] nums)
    {
        var lastSign = 0;
        var result = nums.Length;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            var diffSign = Math.Sign(nums[i + 1] - nums[i]);
            if (diffSign == 0 || diffSign == lastSign)
            {
                result--;
            }
            else
            {
                lastSign = diffSign;
            }
        }

        return result;
    }
}