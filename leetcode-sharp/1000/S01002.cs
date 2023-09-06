namespace leetcode_sharp;

// 1002. Find Common Characters
// https://leetcode.com/problems/find-common-characters/
public class S01002
{
    private const int MaxLetters = 26;

    public IList<string> CommonChars(string[] words)
    {
        var count = new int[MaxLetters];
        Array.Fill(count, int.MaxValue);

        foreach (var word in words)
        {
            var count2 = new int[MaxLetters];
            foreach (var c in word)
            {
                ++count2[c - 'a'];
            }

            for (var i = 0; i < MaxLetters; ++i)
            {
                count[i] = Math.Min(count[i], count2[i]);
            }
        }

        var res = new List<string>();

        for (var i = 0; i < MaxLetters; ++i)
        {
            for (var j = 0; j < count[i]; ++j)
            {
                res.Add(new string((char) (i + 'a'), 1));
            }
        }

        return res;
    }
}