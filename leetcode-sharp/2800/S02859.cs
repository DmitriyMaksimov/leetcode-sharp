namespace leetcode_sharp;

// 2859. Sum of Values at Indices With K Set Bits
// https://leetcode.com/problems/sum-of-values-at-indices-with-k-set-bits
public class S02859
{
    public int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        var res = 0;

        for (var i = 0; i < nums.Count; i++)
        {
            var c = 0;
            var copy = i;

            while (copy != 0)
            {
                c += copy & 1;
                copy >>= 1;
            }

            if (c == k)
            {
                res += nums[i];
            }
        }

        return res;
    }
}