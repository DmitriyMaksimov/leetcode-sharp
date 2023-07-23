namespace leetcode_sharp;

// 2348. Number of Zero-Filled Subarrays
// https://leetcode.com/problems/number-of-zero-filled-subarrays/
public class S02348
{
    public long ZeroFilledSubarray(int[] nums)
    {
        var result = 0L;
        var numberOfZeros = 0L;
        
        foreach (var n in nums)
        {
            if (n == 0)
            {
                result += numberOfZeros + 1;
                ++numberOfZeros;
            }
            else
            {
                numberOfZeros = 0;
            }
        }
        
        return result;
    }
}