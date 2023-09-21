namespace leetcode_sharp;

// 2283. Check if Number Has Equal Digit Count and Digit Value
// https://leetcode.com/problems/check-if-number-has-equal-digit-count-and-digit-value/
public class S02283
{
    public bool DigitCount(string num)
    {
        var dictionary = new Dictionary<char, int>();
        foreach (var c in num)
        {
            dictionary[c] = dictionary.GetValueOrDefault(c) + 1;
        }

        return !num.Where((t, i) => dictionary.GetValueOrDefault((char) ('0' + i)) != t - '0').Any();
    }
}