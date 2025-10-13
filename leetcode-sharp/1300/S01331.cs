namespace leetcode_sharp;

// 1331. Rank Transform of an Array
// https://leetcode.com/problems/rank-transform-of-an-array/
public class S01331
{
    public int[] ArrayRankTransform(int[] arr)
    {
        var sorted = arr.Order().Distinct().ToArray();
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < sorted.Length; i++)
        {
            dict.Add(sorted[i], i + 1);
        }

        var result = new int[arr.Length];
        for (var i = 0; i < arr.Length; i++)
        {
            result[i] = dict[arr[i]];
        }

        return result;
    }
}