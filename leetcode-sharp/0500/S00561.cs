namespace leetcode_sharp;

// 561. Array Partition
// https://leetcode.com/problems/array-partition/
public class S00561
{
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;
        
        for (var i = 0; i < nums.Length; i += 2)
        {
            result += nums[i];
        }
        
        return result;
    }
}