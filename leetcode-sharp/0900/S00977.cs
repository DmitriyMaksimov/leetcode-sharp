namespace leetcode_sharp;

// 977. Squares of a Sorted Array
// https://leetcode.com/problems/squares-of-a-sorted-array/
public class S00977
{
    public int[] SortedSquares(int[] nums)
    {
        return nums.Select(x => x * x).Order().ToArray();
    }
}