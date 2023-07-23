namespace leetcode_sharp;

// 1941. Check if All Characters Have Equal Number of Occurrences
// https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/
public class S01941
{
    public bool AreOccurrencesEqual(string s)
    {
        var dictionary = new Dictionary<char, int>();

        foreach (var ch in s)
        {
            dictionary[ch] = dictionary.GetValueOrDefault(ch) + 1;
        }

        var firstCount = dictionary.First().Value;
        
        return dictionary.Values.All(x => x == firstCount);
    }
}