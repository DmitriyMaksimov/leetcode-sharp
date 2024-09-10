namespace leetcode_sharp;

// 1338. Reduce Array Size to The Half
// https://leetcode.com/problems/reduce-array-size-to-the-half
public class S01338
{
    public int MinSetSize(int[] arr)
    {
        Dictionary<int, int> cnt = [];
        foreach (var x in arr)
        {
            cnt[x] = cnt.GetValueOrDefault(x) + 1;
        }

        var frequencies = cnt.Values.Order().ToList();

        var result = 0;
        var removed = 0;
        var half = arr.Length / 2;
        var i = frequencies.Count - 1;

        while (removed < half)
        {
            result++;
            removed += frequencies[i--];
        }

        return result;
    }
}
