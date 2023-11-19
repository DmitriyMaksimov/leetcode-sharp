namespace leetcode_sharp;

// 2903. Find Indices With Index and Value Difference I
// https://leetcode.com/problems/find-indices-with-index-and-value-difference-i
public class S02903
{
    public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
    {
        var minI = 0;
        var maxI = 0;
        var n = nums.Length;

        for (var i = indexDifference; i < n; i++)
        {
            if (nums[i - indexDifference] < nums[minI]) minI = i - indexDifference;
            if (nums[i - indexDifference] > nums[maxI]) maxI = i - indexDifference;
            if (nums[i] - nums[minI] >= valueDifference) return new[] {minI, i};
            if (nums[maxI] - nums[i] >= valueDifference) return new[] {maxI, i};
        }

        return new[] {-1, -1};
    }
}