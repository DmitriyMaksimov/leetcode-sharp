namespace leetcode_sharp;

// 2981. Find Longest Special Substring That Occurs Thrice I
// https://leetcode.com/problems/find-longest-special-substring-that-occurs-thrice-i
public class S02981
{
    public int MaximumLength(string s)
    {
        var dictionary = new Dictionary<(char Ch, int Freq), int>();

        for (var i = 0; i < s.Length; i++)
        {
            var count = 1;
            var key = (s[i], count);

            dictionary[key] = dictionary.GetValueOrDefault(key) + 1;

            for (var j = i; j < s.Length; j++)
            {
                if (j + 1 < s.Length && s[j] == s[j + 1])
                {
                    count++;
                    key = (s[i], count);

                    dictionary[key] = dictionary.GetValueOrDefault(key) + 1;
                }
                else
                {
                    break;
                }
            }
        }

        var result = dictionary.Where(entry => entry.Value >= 3).Select(entry => entry.Key.Freq).Prepend(0).Max();

        return result == 0 ? -1 : result;
    }
}
