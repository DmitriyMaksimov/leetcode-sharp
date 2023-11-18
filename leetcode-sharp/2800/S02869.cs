namespace leetcode_sharp;

// 2869. Minimum Operations to Collect Elements
// https://leetcode.com/problems/minimum-operations-to-collect-elements
public class S02869
{
    public int MinOperations(IList<int> nums, int k)
    {
        var hashSet = new HashSet<int>();

        for (var i = nums.Count - 1; i >= 0; i--)
        {
            if (nums[i] <= k)
            {
                hashSet.Add(nums[i]);

                if (hashSet.Count == k)
                {
                    return nums.Count - i;
                }
            }
        }

        return nums.Count;
    }
}