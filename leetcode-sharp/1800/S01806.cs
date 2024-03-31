namespace leetcode_sharp;

// 1806. Minimum Number of Operations to Reinitialize a Permutation
// https://leetcode.com/problems/minimum-number-of-operations-to-reinitialize-a-permutation
public class S01806
{
    public int ReinitializePermutation(int n)
    {
        var result = 0;
        var i = 1;

        while (result == 0 || i > 1)
        {
            if (i < n / 2)
            {
                i *= 2;
            }
            else
            {
                i = (i - n / 2) * 2 + 1;
            }

            result++;
        }

        return result;
    }
}