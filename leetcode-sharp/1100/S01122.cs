namespace leetcode_sharp;

// 1122. Relative Sort Array
// https://leetcode.com/problems/relative-sort-array/
public class S01122
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var dict = new Dictionary<int, int>();
        foreach (var i in arr1)
        {
            dict[i] = dict.GetValueOrDefault(i) + 1;
        }

        var result = new List<int>();
        foreach (var i in arr2)
        {
            for (var j = 0; j < dict[i]; j++)
            {
                result.Add(i);
            }

            dict.Remove(i);
        }

        foreach (var i in dict.Keys.OrderBy(x => x))
        {
            for (var j = 0; j < dict[i]; j++)
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
}