namespace leetcode_sharp;

// 520. Detect Capital
// https://leetcode.com/problems/detect-capital/
public class S00520
{
    public bool DetectCapitalUse(string word)
    {
        var restOfTheWord = word[1..];
        
        return char.IsUpper(word[0]) ? restOfTheWord.All(char.IsLower) || restOfTheWord.All(char.IsUpper) : restOfTheWord.All(char.IsLower);
    }
}