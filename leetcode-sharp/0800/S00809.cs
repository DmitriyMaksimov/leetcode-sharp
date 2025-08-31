namespace leetcode_sharp;

// 809. Expressive Words
// https://leetcode.com/problems/expressive-words
public class S00809
{
    public int ExpressiveWords(string s, string[] words)
    {
        return words.Count(w => Check(s, w));
    }

    private bool Check(string s, string word)
    {
        var left = 0;
        var right = word.Length;

        for (var i = 0; i < s.Length; i++)
        {
            if (left < right && s[i] == word[left])
            {
                left++;
            }
            else if (i > 1 && s[i] == s[i - 1] && s[i - 1] == s[i - 2])
            {
                // stretchy character, skip
            }
            else if (i > 0 && i < s.Length - 1 && s[i - 1] == s[i] && s[i] == s[i + 1])
            {
                // stretchy middle, skip
            }
            else
            {
                return false;
            }
        }

        return left == right;
    }
}