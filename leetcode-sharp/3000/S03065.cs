namespace leetcode_sharp;

// 3065. Minimum Operations to Exceed Threshold Value I
// https://leetcode.com/problems/minimum-operations-to-exceed-threshold-value-i
public class S03065
{
    public int MinOperations(int[] nums, int k)
    {
        return nums.Count(num => num < k);
    }
}