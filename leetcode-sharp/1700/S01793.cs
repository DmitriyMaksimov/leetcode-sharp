namespace leetcode_sharp;

// 1793. Maximum Score of a Good Subarray
// https://leetcode.com/problems/maximum-score-of-a-good-subarray
public class S01793
{
    public int MaximumScore(int[] nums, int k)
    {
        var left = k;
        var right = k;
        var minVal = nums[k];
        var maxScore = minVal;

        while (left > 0 || right < nums.Length - 1)
        {
            if (left == 0 || (right < nums.Length - 1 && nums[right + 1] > nums[left - 1]))
            {
                right++;
            }
            else
            {
                left--;
            }

            minVal = Math.Min(minVal, Math.Min(nums[left], nums[right]));
            maxScore = Math.Max(maxScore, minVal * (right - left + 1));
        }

        return maxScore;
    }
}