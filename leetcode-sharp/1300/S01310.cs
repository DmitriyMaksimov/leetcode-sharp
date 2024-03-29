namespace leetcode_sharp;

// 1310. XOR Queries of a Subarray
// https://leetcode.com/problems/xor-queries-of-a-subarray
public class S01310
{
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        var result = new int[queries.Length];
        
        for (var i = 1; i < arr.Length; ++i)
        {
            arr[i] ^= arr[i - 1];
        }

        for (var i = 0; i < queries.Length; ++i)
        {
            var query = queries[i];
            result[i] = query[0] != 0 ? arr[query[0] - 1] ^ arr[query[1]] : arr[query[1]];
        }

        return result;
    }
}