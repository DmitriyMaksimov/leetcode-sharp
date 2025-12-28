namespace leetcode_sharp;

// 3774. Absolute Difference Between Maximum and Minimum K Elements
// https://leetcode.com/problems/absolute-difference-between-maximum-and-minimum-k-elements
public class S03774
{
    public int AbsDifference(int[] nums, int k)
    {
        Array.Sort(nums);
        return nums.TakeLast(k).Sum() - nums.Take(k).Sum();
    }
}