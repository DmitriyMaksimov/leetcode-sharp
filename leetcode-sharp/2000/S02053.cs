namespace leetcode_sharp;

// 2053. Kth Distinct String
// https://leetcode.com/problems/kth-distinct-string/
public class S02053
{
    public string KthDistinct(string[] arr, int k)
    {
        var dict = new Dictionary<string, int>();

        foreach (var s in arr)
        {
            dict[s] = dict.GetValueOrDefault(s) + 1;
        }

        var distinct = dict.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
        return k > distinct.Length ? "" : distinct[k - 1];
    }
}