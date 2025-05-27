using System.Text;

namespace leetcode_sharp;

// 3561. Resulting String After Adjacent Removals
// https://leetcode.com/problems/resulting-string-after-adjacent-removals
public class S03561
{
    public string ResultingString(string s)
    {
        var sb = new StringBuilder();

        foreach (var ch in s)
        {
            if (sb.Length > 0)
            {
                var top = sb[^1];
                var diff = Math.Abs(top - ch);

                if (diff is 1 or 25)
                {
                    sb.Remove(sb.Length - 1, 1);
                    continue;
                }
            }

            sb.Append(ch);
        }

        return sb.ToString();
    }
}
