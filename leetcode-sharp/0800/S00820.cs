namespace leetcode_sharp;

// 820. Short Encoding of Words
// https://leetcode.com/problems/short-encoding-of-words
public class S00820
{
    public int MinimumLengthEncoding(string[] words)
    {
        HashSet<string> s = [..words];

        foreach (var w in words)
        {
            for (var i = 1; i < w.Length; i++)
            {
                s.Remove(w[i..]);
            }
        }

        return s.Sum(w => w.Length + 1);
    }
}
