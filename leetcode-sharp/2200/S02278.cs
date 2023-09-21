namespace leetcode_sharp;

// 2278. Percentage of Letter in String
// https://leetcode.com/problems/percentage-of-letter-in-string
public class S02278
{
    public int PercentageLetter(string s, char letter)
    {
        return s.Count(c => c == letter) * 100 / s.Length;
    }
}