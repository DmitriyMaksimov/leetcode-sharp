namespace leetcode_sharp;

// 3350. Adjacent Increasing Subarrays Detection II
// https://leetcode.com/problems/adjacent-increasing-subarrays-detection-ii
public class S03350
{
    public int MaxIncreasingSubarrays(IList<int> nums)
    {
        var n = nums.Count;
        var up = 1;
        var preMaxUp = 0;
        var result = 0;

        for (var i = 1; i < n; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                up++;
            }
            else
            {
                preMaxUp = up;
                up = 1;
            }

            result = Math.Max(result, Math.Max(up / 2, Math.Min(preMaxUp, up)));
        }

        return result;
    }
}