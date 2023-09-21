namespace leetcode_sharp;

// 2309. Greatest English Letter in Upper and Lower Case
// https://leetcode.com/problems/greatest-english-letter-in-upper-and-lower-case
public class S02309
{
    public string GreatestLetter(string s)
    {
        var lowercaseLetters = new HashSet<char>();
        var uppercaseLetters = new HashSet<char>();

        foreach (var c in s)
        {
            if (char.IsLower(c))
            {
                lowercaseLetters.Add(c);
            }
            else if (char.IsUpper(c))
            {
                uppercaseLetters.Add(c);
            }
        }

        for (var c = 'Z'; c >= 'A'; c--)
        {
            if (uppercaseLetters.Contains(c) && lowercaseLetters.Contains(char.ToLower(c)))
            {
                return c.ToString();
            }
        }

        return string.Empty;
    }
}