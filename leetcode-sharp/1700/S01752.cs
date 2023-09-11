namespace leetcode_sharp;

// 1752. Check if Array Is Sorted and Rotated
// https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/
public class S01752
{
    public bool Check(int[] nums)
    {
        return nums.Where((t, i) => t > nums[(i + 1) % nums.Length]).Count() <= 1;
    }
}