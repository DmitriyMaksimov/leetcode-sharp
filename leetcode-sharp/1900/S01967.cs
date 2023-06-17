namespace leetcode_sharp;

// 1967. Number of Strings That Appear as Substrings in Word
// https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/
public class S01967
{
    public int NumOfStrings(string[] patterns, string word)
    {
        return patterns.Count(word.Contains);
    }
}