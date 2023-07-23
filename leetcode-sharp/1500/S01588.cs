namespace leetcode_sharp;

// 1588. Sum of All Odd Length Subarrays
// https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
public class S01588
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        var n = arr.Length;
        var res = 0;
        for (var l = 1; l < n + 1; l += 2)
        {
            for (var i = 0; i < n - l + 1; i++)
            {
                res += arr[i..(i + l)].Sum();
            }
        }

        return res;
    }
}