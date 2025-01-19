namespace leetcode_sharp;

// 3423. Maximum Difference Between Adjacent Elements in a Circular Array
// https://leetcode.com/problems/maximum-difference-between-adjacent-elements-in-a-circular-array
public class S03423
{
    public int MaxAdjacentDistance(int[] nums)
    {
        return nums.Select((t, i) => Math.Abs(nums[(i + 1) % nums.Length] - t)).Max();
    }
}
