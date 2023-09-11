using System.Text;

namespace leetcode_sharp;

// 1805. Number of Different Integers in a String
// https://leetcode.com/problems/number-of-different-integers-in-a-string/
public class S01805
{
    public int NumDifferentIntegers(string word)
    {
        var hashSet = new HashSet<string>();
        var sb = new StringBuilder();

        foreach (var c in word)
        {
            if (char.IsDigit(c))
            {
                sb.Append(c);
            }
            else
            {
                if (sb.Length > 0)
                {
                    hashSet.Add(sb.ToString().TrimStart('0'));
                    sb.Clear();
                }
            }
        }

        if (sb.Length > 0)
        {
            hashSet.Add(sb.ToString().TrimStart('0'));
        }

        return hashSet.Count;
    }
}