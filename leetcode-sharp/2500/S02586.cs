namespace leetcode_sharp;

// 2586. Count the Number of Vowel Strings in Range
// https://leetcode.com/problems/count-the-number-of-vowel-strings-in-range
public class S02586
{
    private readonly HashSet<char> _vowels = new() {'a', 'e', 'i', 'o', 'u'};
    
    public int VowelStrings(string[] words, int left, int right)
    {
        return words.Skip(left).Take(right - left + 1).Count(isVowelString);
    }

    private bool isVowelString(string s)
    {
        return _vowels.Contains(s[0]) && _vowels.Contains(s[^1]);
    }
}