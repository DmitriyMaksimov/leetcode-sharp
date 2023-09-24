namespace leetcode_sharp;

// 2475. Number of Unequal Triplets in Array
// https://leetcode.com/problems/number-of-unequal-triplets-in-array/
public class S02475
{
    public int UnequalTriplets(int[] nums)
    {
        var count = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] != nums[j] && nums[i] != nums[k] && nums[j] != nums[k])
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}