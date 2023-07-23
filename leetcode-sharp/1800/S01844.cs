namespace leetcode_sharp;

// 1844. Replace All Digits with Characters
// https://leetcode.com/problems/replace-all-digits-with-characters/
public class S01844
{
    public string ReplaceDigits(string s)
    {
        var chars = s.ToCharArray();

        for (var i = 1; i < s.Length; i += 2)
        {
            chars[i] = shift(chars[i - 1], chars[i] - '0');
        }
        
        return new string(chars);
    }

    private static char shift(char ch, int n)
    {
        return (char) (ch + n);
    }
}