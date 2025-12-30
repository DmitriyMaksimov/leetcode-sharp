namespace leetcode_sharp;

// 3674. Minimum Operations to Equalize Array
// https://leetcode.com/problems/minimum-operations-to-equalize-array
public class S03674
{
    public int MinOperations(int[] nums)
    {
        var allEqual = true;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[0])
            {
                allEqual = false;
                break;
            }
        }

        return allEqual ? 0 : 1;
    }
}