namespace leetcode_sharp;

// 17. Letter Combinations of a Phone Number
// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
public class S00017
{
    private readonly List<string> _result = new List<string>();
    private readonly string[] _dial = {"0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return _result;
        }

        helper("", 0, digits);
        return _result;
    }

    private void helper(string comb, int index, string digits)
    {
        if (index == digits.Length)
        {
            _result.Add(comb);
            return;
        }

        var letters = _dial[digits[index] - '0'];
        foreach (var letter in letters)
        {
            helper(comb + letter, index + 1, digits);
        }
    }
}