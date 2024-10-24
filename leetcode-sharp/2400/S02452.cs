namespace leetcode_sharp;

// 2452. Words Within Two Edits of Dictionary
// https://leetcode.com/problems/words-within-two-edits-of-dictionary
public class S02452
{
    public IList<string> TwoEditWords(string[] queries, string[] dictionary)
    {
        List<string> ans = [];

        ans.AddRange(queries.Where(query => dictionary.Select(word => Diff(query, word)).Any(d => d <= 2)));

        return ans;
    }

    private static int Diff(string a, string b)
    {
        var n = a.Length;
        var same = 0;

        for (var i = 0; i < n; i++)
        {
            if (a[i] == b[i])
            {
                same++;
            }
        }

        var count = n - same;
        return count;
    }
}
