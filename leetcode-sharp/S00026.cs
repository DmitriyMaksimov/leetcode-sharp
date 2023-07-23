namespace leetcode_sharp;

// 26. Remove Duplicates from Sorted Array
// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class S00026
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        
        var newLength = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[newLength] != nums[i])
            {
                nums[++newLength] = nums[i];
            }
        }
        
        return newLength + 1;
    }
}