namespace leetcode_sharp;

// 3438. Find Valid Pair of Adjacent Digits in String
// https://leetcode.com/problems/find-valid-pair-of-adjacent-digits-in-string
public class S03438
{
    public string FindValidPair(string s)
    {
        Dictionary<char, int> frequencies = [];
        foreach (var c in s)
        {
            frequencies[c] = frequencies.GetValueOrDefault(c) + 1;
        }

        for (var i = 0; i < s.Length - 1; i++)
        {
            var currentDigit = s[i];
            var nextDigit = s[i + 1];
            if (currentDigit != nextDigit && frequencies[currentDigit] == currentDigit - '0' && frequencies[nextDigit] == nextDigit - '0')
            {
                return s.Substring(i, 2);
            }
        }

        return "";
    }
}
