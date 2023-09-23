using System.Text;

namespace leetcode_sharp;

// 2451. Odd String Difference
// https://leetcode.com/problems/odd-string-difference/
public class S02451
{
    public string OddString(string[] words)
    {
        var differenceCounts = new Dictionary<string, int>();

        foreach (var word in words)
        {
            var difference = getDifference(word);
            differenceCounts[difference] = differenceCounts.GetValueOrDefault(difference) + 1;
        }

        foreach (var word in words)
        {
            if (differenceCounts[getDifference(word)] == 1)
            {
                return word;
            }
        }

        return string.Empty;
    }

    private static string getDifference(string word)
    {
        var difference = new StringBuilder();
        for (var i = 0; i < word.Length - 1; i++)
        {
            difference.Append(word[i + 1] - word[i]);
            difference.Append(',');
        }

        return difference.ToString();
    }
}