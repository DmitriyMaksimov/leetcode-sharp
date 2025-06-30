using System.Text;

namespace leetcode_sharp;

// 3076. Shortest Uncommon Substring in an Array
// https://leetcode.com/problems/shortest-uncommon-substring-in-an-array
public class S03076
{
    public string[] ShortestSubstrings(string[] arr)
    {
        var n = arr.Length;
        var result = Enumerable.Repeat(string.Empty, n).ToArray();

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < arr[i].Length; j++)
            {
                var sb = new StringBuilder();
                for (var k = j; k < arr[i].Length; k++)
                {
                    sb.Append(arr[i][k]);
                    var sub = sb.ToString();

                    if (!CheckIfExists(sub, i, arr) &&
                        (string.IsNullOrWhiteSpace(result[i]) ||
                         sub.Length < result[i].Length ||
                         (sub.Length == result[i].Length && string.CompareOrdinal(sub, result[i]) < 0)))
                    {
                        result[i] = sub;
                    }
                }
            }
        }

        return result;
    }

    private static bool CheckIfExists(string s, int idx, string[] source)
    {
        return source.Where((t, m) => m != idx && t.Contains(s)).Any();
    }
}