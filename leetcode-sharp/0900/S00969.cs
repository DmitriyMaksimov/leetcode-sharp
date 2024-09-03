namespace leetcode_sharp;

// 969. Pancake Sorting
// https://leetcode.com/problems/pancake-sorting
public class S00969
{
    public IList<int> PancakeSort(int[] arr)
    {
        List<int> res = [];
        for (var x = arr.Length; x > 0; --x)
        {
            var i = Array.IndexOf(arr, x);

            Reverse(arr, i + 1);
            res.Add(i + 1);

            Reverse(arr, x);
            res.Add(x);
        }

        return res;
    }

    private static void Reverse(int[] arr, int k)
    {
        for (int i = 0, j = k - 1; i < j; i++, j--)
        {
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
    }
}
