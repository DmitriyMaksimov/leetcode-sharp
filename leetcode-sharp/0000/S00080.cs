namespace leetcode_sharp;

// 80. Remove Duplicates from Sorted Array II
// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
public class S00080
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return nums.Length;
        }
        
        var j = 1;
        
        for (var i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[j - 1])
            {
                nums[++j] = nums[i];
            }
        }

        return j + 1;
    }
}