namespace leetcode_sharp;

// 3314. Construct the Minimum Bitwise Array I
// https://leetcode.com/problems/construct-the-minimum-bitwise-array-i
public class S03314
{
    public int[] MinBitwiseArray(IList<int> nums)
    {
        var result = Enumerable.Repeat(-1, nums.Count).ToArray();

        for (var i = 0; i < nums.Count; i++)
        {
            for (int j = 0; j < nums[i]; j++)
            {
                if ((j | (j + 1)) == nums[i])
                {
                    result[i] = j;
                    break;
                }
            }
        }

        return result;
    }
}
