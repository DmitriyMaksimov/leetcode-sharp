namespace leetcode_sharp;

// 819. Most Common Word
// https://leetcode.com/problems/most-common-word/
public class S00819
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        var bannedSet = new HashSet<string>(banned);
        var dictionary = new Dictionary<string, int>();

        foreach (var word in paragraph.ToLower().Split(" !?',;.".ToCharArray(), StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
        {
            if (bannedSet.Contains(word))
            {
                continue;
            }

            dictionary[word] = dictionary.GetValueOrDefault(word) + 1;
        }

        return dictionary.MaxBy(pair => pair.Value).Key;
    }
}