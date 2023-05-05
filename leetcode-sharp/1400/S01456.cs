namespace leetcode_sharp;

// 1456. Maximum Number of Vowels in a Substring of Given Length
// https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
public class S01456
{
    private readonly HashSet<char> _vowels = new() {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

    public int MaxVowels(string s, int k)
    {
        var vowels = 0;
        
        foreach (var ch in s[..k])
        {
            if (isVowel(ch))
            {
                ++vowels;
            }
        }

        var result = vowels;

        for (var i = 1; i <= s.Length - k; i++)
        {
            // Remove char which is out of sliding window and add a new one
            var oldChar = s[i - 1];
            var newChar = s[i + k - 1];
            if (isVowel(oldChar))
            {
                --vowels;
            }
            if (isVowel(newChar))
            {
                ++vowels;
            }

            result = Math.Max(result, vowels);
            if (result == k)
            {
                // We can't get greater than the window size => return early
                break;
            }
        }

        return result;
    }

    private bool isVowel(char c)
    {
        return _vowels.Contains(c);
    }
}