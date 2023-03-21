namespace leetcode_sharp;

// 1920. Build Array from Permutation
// https://leetcode.com/problems/build-array-from-permutation/
public class S01920
{
    public int[] BuildArray(int[] nums)
    {
        var retVal = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            retVal[i] = nums[nums[i]];
        }
        return retVal;
    }
}