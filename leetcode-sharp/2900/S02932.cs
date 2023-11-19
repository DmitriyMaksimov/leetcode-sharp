namespace leetcode_sharp;

// 2932. Maximum Strong Pair XOR I
// https://leetcode.com/problems/maximum-strong-pair-xor-i
public class S02932
{
    public int MaximumStrongPairXor(int[] nums)
    {
        var result = 0;
        
        foreach (var x in nums)
        {
            foreach (var y in nums)
            {
                if (Math.Abs(x - y) <= Math.Min(x, y))
                {
                    result = Math.Max(result, x ^ y);
                }
            }
        }

        return result;
    }
}