namespace leetcode_sharp;

// 274. H-Index
// https://leetcode.com/problems/h-index/
public class S00274
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations);
        var result = 0;
        var n = citations.Length;

        for (var i = 0; i < n; i++)
        {
            result = Math.Max(result, Math.Min(citations[i], n - i));
        }

        return result;
    }
}