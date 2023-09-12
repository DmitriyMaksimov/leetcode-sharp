namespace leetcode_sharp;

// 1974. Minimum Time to Type Word Using Special Typewriter
// https://leetcode.com/problems/minimum-time-to-type-word-using-special-typewriter/
public class S01974
{
    public int MinTimeToType(string word)
    {
        const int totalChars = 26;
        var result = 0;
        var current = 'a';

        foreach (var c in word)
        {
            var diff = Math.Abs(c - current);
            result += Math.Min(diff, totalChars - diff) + 1;
            current = c;
        }

        return result;
    }
}