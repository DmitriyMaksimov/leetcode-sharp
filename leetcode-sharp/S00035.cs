namespace leetcode_sharp;

// 35. Search Insert Position
// https://leetcode.com/problems/search-insert-position/
public class S00035
{
    public int SearchInsert(int[] nums, int target)
    {
        var index = Array.BinarySearch(nums, target);
        return index >= 0 ? index : ~index;
    }
}