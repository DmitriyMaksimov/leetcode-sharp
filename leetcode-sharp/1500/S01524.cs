namespace leetcode_sharp;

// 1524. Number of Sub-arrays With Odd Sum
// https://leetcode.com/problems/number-of-sub-arrays-with-odd-sum
public class S01524
{
    public int NumOfSubarrays(int[] arr)
    {
        const int mod = 1_000_000_007;
        var current = 0;
        var result = 0;
        int[] counts = [1, 0];

        foreach (var n in arr)
        {
            current ^= n & 1;
            result = (result + counts[1 - current]) % mod;
            counts[current]++;
        }

        return result;
    }
}
