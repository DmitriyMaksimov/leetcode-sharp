namespace leetcode_sharp;

// 1647. Minimum Deletions to Make Character Frequencies Unique
// https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
public class S01647
{
    public int MinDeletions(string s)
    {
        var freq = new int[26];
        foreach (var c in s)
        {
            freq[c - 'a']++;
        }

        var res = 0;
        var set = new HashSet<int>();
        foreach (var f in freq)
        {
            var item = f;

            while (item > 0 && !set.Add(item))
            {
                item--;
                res++;
            }
        }

        return res;
    }
}