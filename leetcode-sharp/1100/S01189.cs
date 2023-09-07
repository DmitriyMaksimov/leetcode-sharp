namespace leetcode_sharp;

// 1189. Maximum Number of Balloons
// https://leetcode.com/problems/maximum-number-of-balloons/
public class S01189
{
    public int MaxNumberOfBalloons(string text)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in text)
        {
            dict[c] = dict.GetValueOrDefault(c) + 1;
        }

        var min = int.MaxValue;

        foreach (var c in "balloon")
        {
            if (!dict.ContainsKey(c))
            {
                return 0;
            }

            min = c is 'l' or 'o' ? Math.Min(min, dict[c] / 2) : Math.Min(min, dict[c]);
        }

        return min;
    }
}