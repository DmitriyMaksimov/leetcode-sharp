namespace leetcode_sharp;

// 3315. Construct the Minimum Bitwise Array II
// https://leetcode.com/problems/construct-the-minimum-bitwise-array-ii
public class S03315
{
    public int[] MinBitwiseArray(IList<int> nums)
    {
        var result = new int[nums.Count];

        for (var i = 0; i < nums.Count; i++)
        {
            var p = nums[i];

            if (p == 2)
            {
                result[i] = -1;
                continue;
            }

            var n = -1;
            for (var bit = 1; bit < 32; bit++)
            {
                if (((p >> bit) & 1) == 0)
                {
                    n = p ^ (1 << (bit - 1));
                    break;
                }
            }

            result[i] = n;
        }

        return result;
    }
}