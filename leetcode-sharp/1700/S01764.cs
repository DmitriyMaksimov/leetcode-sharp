namespace leetcode_sharp;

// 1764. Form Array by Concatenating Subarrays of Another Array
// https://leetcode.com/problems/form-array-by-concatenating-subarrays-of-another-array
public class S01764
{
    public bool CanChoose(int[][] groups, int[] nums)
    {
        return CanChoose(groups, nums, 0, 0);
    }

    private static bool CanChoose(int[][] groups, int[] nums, int i, int j)
    {
        if (i >= groups.Length)
        {
            return true;
        }

        for (; j <= nums.Length - groups[i].Length; ++j)
        {
            for (var groupIndex = 0; groupIndex <= groups[i].Length; ++groupIndex)
            {
                if (groupIndex == groups[i].Length)
                {
                    return CanChoose(groups, nums, i + 1, j + groups[i].Length);
                }

                if (nums[j + groupIndex] != groups[i][groupIndex])
                {
                    break;
                }
            }
        }

        return false;
    }
}
