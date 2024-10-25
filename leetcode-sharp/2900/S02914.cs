namespace leetcode_sharp;

// 2914. Minimum Number of Changes to Make Binary String Beautiful
// https://leetcode.com/problems/minimum-number-of-changes-to-make-binary-string-beautiful
public class S02914
{
    public int MinChanges(string s)
    {
        var count = 0;

        for (var i = 0; i < s.Length - 1; i += 2)
        {
            if (s[i] != s[i + 1])
            {
                count++;
            }
        }

        return count;
    }
}
