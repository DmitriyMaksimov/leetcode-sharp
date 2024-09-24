namespace leetcode_sharp;

// 2799. Count Complete Subarrays in an Array
// https://leetcode.com/problems/count-complete-subarrays-in-an-array
public class S02799
{
    public int CountCompleteSubarrays(int[] nums)
    {
        var hashSet = nums.ToHashSet();

        var n = nums.Length;
        var k = hashSet.Count;
        var result = 0;
        var i = 0;

        Dictionary<int, int> counts = [];

        for (var j = 0; j < n; ++j)
        {
            if (counts.GetValueOrDefault(nums[j]) == 0)
            {
                k--;
            }

            counts[nums[j]] = counts.GetValueOrDefault(nums[j]) + 1;

            while (k == 0)
            {
                counts[nums[i]] = counts[nums[i]] - 1;
                if (counts[nums[i]] == 0)
                {
                    k++;
                }

                i++;
            }

            result += i;
        }

        return result;
    }
}
