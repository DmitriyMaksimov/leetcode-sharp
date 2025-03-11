namespace leetcode_sharp;

// 1839. Longest Substring Of All Vowels in Order
// https://leetcode.com/problems/longest-substring-of-all-vowels-in-order
public class S01839
{
    public int LongestBeautifulSubstring(string word)
    {
        var result = 0;
        var seen = new HashSet<char>();

        for (int lo = -1, hi = 0; hi < word.Length; hi++)
        {
            if (hi > 0 && word[hi - 1] > word[hi])
            {
                seen.Clear();
                lo = hi - 1;
            }

            seen.Add(word[hi]);

            if (seen.Count == 5)
            {
                result = Math.Max(result, hi - lo);
            }
        }

        return result;
    }
}
