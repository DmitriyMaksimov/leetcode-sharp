namespace leetcode_sharp;

// 704. Binary Search
// https://leetcode.com/problems/binary-search/
public class S00704
{
    public int Search(int[] nums, int target)
    {
        var index = Array.BinarySearch(nums, target);
        return index >= 0 ? index : -1;
    }
}