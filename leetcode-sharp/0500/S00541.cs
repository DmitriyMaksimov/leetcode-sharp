namespace leetcode_sharp;

// 541. Reverse String II
// https://leetcode.com/problems/reverse-string-ii/
public class S00541
{
    public string ReverseStr(string s, int k)
    {
        var n = s.Length;
        var a = s.ToCharArray();

        for (var i = 0; i < n; i += 2 * k)
        {
            var start = i;
            var end = Math.Min(i + k - 1, n - 1);
            while (start < end)
            {
                (a[start], a[end]) = (a[end], a[start]);
                ++start;
                --end;
            }
        }

        return new string(a);
    }
}