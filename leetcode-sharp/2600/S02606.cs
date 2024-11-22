namespace leetcode_sharp;

// 2606. Find the Substring With Maximum Cost
// https://leetcode.com/problems/find-the-substring-with-maximum-cost
public class S02606
{
    public int MaximumCostSubstring(string s, string chars, int[] vals)
    {
        var counts = Enumerable.Range(1, 26).ToArray();

        for (var i = 0; i < chars.Length; i++)
        {
            counts[chars[i] - 'a'] = vals[i];
        }

        var n = s.Length;
        var vt = new int[n];

        for (var i = 0; i < n; i++)
        {
            vt[i] = counts[s[i] - 'a'];
        }

        var result = 0;
        var temp = 0;

        for (var i = 0; i < n; i++)
        {
            temp += vt[i];
            if (temp < 0)
            {
                temp = 0;
            }

            result = Math.Max(result, temp);
        }

        return result;
    }
}
