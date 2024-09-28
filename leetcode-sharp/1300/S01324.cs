namespace leetcode_sharp;

// 1324. Print Words Vertically
// https://leetcode.com/problems/print-words-vertically
public class S01324
{
    public IList<string> PrintVertically(string s)
    {
        var words = s.Split(" ");
        var maxLength = words.Select(w => w.Length).Max();
        var result = Enumerable.Repeat("", maxLength).ToArray();

        for (var i = 0; i < maxLength; ++i)
        {
            foreach (var word in words)
            {
                result[i] += i < word.Length ? word[i] : " ";
            }

            result[i] = result[i].TrimEnd();
        }

        return result;
    }
}
