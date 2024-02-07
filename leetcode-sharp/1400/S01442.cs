namespace leetcode_sharp;

// 1442. Count Triplets That Can Form Two Arrays of Equal XOR
// https://leetcode.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor
public class S01442
{
    public int CountTriplets(int[] arr)
    {
        var n = arr.Length + 1;
        var result = 0;
        var prefix = new int[n];

        for (var i = 1; i < n; ++i)
        {
            prefix[i] = arr[i - 1] ^ prefix[i - 1];
        }

        for (var i = 0; i < n; ++i)
        {
            for (var j = i + 1; j < n; ++j)
            {
                if (prefix[i] == prefix[j])
                {
                    result += j - i - 1;
                }
            }
        }

        return result;
    }
}