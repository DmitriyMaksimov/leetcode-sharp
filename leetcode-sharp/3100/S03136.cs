namespace leetcode_sharp;

// 3136. Valid Word
// https://leetcode.com/problems/valid-word
public class S03136
{
    private readonly HashSet<char> _vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
    
    public bool IsValid(string word)
    {
        var hasVowel = false;
        var hasConsonant = false;

        foreach (var c in word)
        {
            if (_vowels.Contains(c))
            {
                hasVowel = true;
                continue;
            }

            if (char.IsLetter(c))
            {
                hasConsonant = true;
                continue;
            }

            
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return word.Length >= 3 && hasVowel && hasConsonant;
    }
}