namespace leetcode_sharp;

// 2670. Find the Distinct Difference Array
// https://leetcode.com/problems/find-the-distinct-difference-array
public class S02670
{
    public int[] DistinctDifferenceArray(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];
        var distinctElements = new HashSet<int> {nums[n - 1]};

        for (var i = n - 2; i >= 0; i--)
        {
            result[i] = -distinctElements.Count;
            distinctElements.Add(nums[i]);
        }

        distinctElements.Clear();

        for (var i = 0; i <= n - 1; i++)
        {
            distinctElements.Add(nums[i]);
            result[i] += distinctElements.Count;
        }

        return result;
    }
}