namespace leetcode_sharp;

// 1471. The k Strongest Values in an Array
// https://leetcode.com/problems/the-k-strongest-values-in-an-array
public class S01471
{
    public int[] GetStrongest(int[] arr, int k)
    {
        Array.Sort(arr);

        var left = 0;
        var right = arr.Length - 1;
        var p = 0;
        var median = arr[(arr.Length - 1) / 2];

        var res = new int[k];

        while (p < k)
        {
            res[p++] = median - arr[left] > arr[right] - median ? arr[left++] : arr[right--];
        }

        return res;
    }
}
