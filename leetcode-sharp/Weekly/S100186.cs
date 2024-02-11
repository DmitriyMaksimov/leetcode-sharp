namespace leetcode_sharp;

// 100186. Number of Subarrays That Match a Pattern I
public class S100186
{
    public int CountMatchingSubarrays(int[] nums, int[] pattern)
    {
        var count = 0;
        var n = nums.Length;
        var m = pattern.Length;

        for (var i = 0; i < n - m; i++)
        {
            var isMatching = true;

            for (var j = 0; j < m; j++)
            {
                if (pattern[j] == 1 && nums[i + j + 1] <= nums[i + j])
                {
                    isMatching = false;
                    break;
                }

                if (pattern[j] == 0 && nums[i + j + 1] != nums[i + j])
                {
                    isMatching = false;
                    break;
                }

                if (pattern[j] == -1 && nums[i + j + 1] >= nums[i + j])
                {
                    isMatching = false;
                    break;
                }
            }

            if (isMatching)
            {
                count++;
            }
        }

        return count;
    }
}