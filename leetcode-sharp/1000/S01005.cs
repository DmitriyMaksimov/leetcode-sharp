namespace leetcode_sharp;

// 1005. Maximize Sum Of Array After K Negations
// https://leetcode.com/problems/maximize-sum-of-array-after-k-negations/
public class S01005
{
    public int LargestSumAfterKNegations(int[] nums, int k)
    {
        Array.Sort(nums);
        var i = 0;
        while (k > 0 && i < nums.Length && nums[i] < 0)
        {
            nums[i] = -nums[i];
            i++;
            k--;
        }

        Array.Sort(nums);

        if (k % 2 == 1)
        {
            nums[0] = -nums[0];
        }

        return nums.Sum();
    }
}