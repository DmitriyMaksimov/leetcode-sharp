namespace leetcode_sharp;

// 2085. Count Common Words With One Occurrence
// https://leetcode.com/problems/count-common-words-with-one-occurrence/
public class S02085
{
    public int CountWords(string[] words1, string[] words2)
    {
        var dictionary = new Dictionary<string, int>();
        foreach (var word in words1)
        {
            dictionary[word] = dictionary.GetValueOrDefault(word) + 1;
        }

        foreach (var word in words2)
        {
            if (dictionary.TryGetValue(word, out var count) && count < 2)
            {
                dictionary[word]--;
            }
        }
        
        return dictionary.Count(p => p.Value == 0);
    }
}