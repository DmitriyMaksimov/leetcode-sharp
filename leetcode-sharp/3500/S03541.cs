namespace leetcode_sharp;

// 3541. Find Most Frequent Vowel and Consonant
// https://leetcode.com/problems/find-most-frequent-vowel-and-consonant
public class S03541
{
    private readonly HashSet<char> _vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

    public int MaxFreqSum(string s)
    {
        var vowelsFrequencies = new Dictionary<char, int> { ['_'] = 0 };
        var consonantsFrequencies = new Dictionary<char, int> { ['_'] = 0 };

        foreach (var c in s)
        {
            if (_vowels.Contains(c))
            {
                vowelsFrequencies[c] = vowelsFrequencies.GetValueOrDefault(c) + 1;
            }
            else
            {
                consonantsFrequencies[c] = consonantsFrequencies.GetValueOrDefault(c) + 1;
            }
        }

        return vowelsFrequencies.Max(freq => freq.Value) + consonantsFrequencies.Max(freq => freq.Value);
    }
}
