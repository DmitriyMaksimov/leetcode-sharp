namespace leetcode_sharp;

// 884. Uncommon Words from Two Sentences
// https://leetcode.com/problems/uncommon-words-from-two-sentences/
public class S00884
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var dict = new Dictionary<string, int>();
        foreach (var s in s1.Split(' '))
        {
            dict[s] = dict.GetValueOrDefault(s) + 1;
        }

        foreach (var s in s2.Split(' '))
        {
            dict[s] = dict.GetValueOrDefault(s) + 1;
        }

        return dict.Where(kv => kv.Value == 1).Select(kv => kv.Key).ToArray();
    }
}