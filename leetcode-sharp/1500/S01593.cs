namespace leetcode_sharp;

// 1593. Split a String Into the Max Number of Unique Substrings
// https://leetcode.com/problems/split-a-string-into-the-max-number-of-unique-substrings
public class S01593
{
    private readonly HashSet<string> _hashSet = [];

    public int MaxUniqueSplit(string s)
    {
        return Dfs(0, s);
    }

    private int Dfs(int index, string s)
    {
        if (index >= s.Length)
        {
            return 0;
        }

        var result = -1;

        for (var i = index + 1; i <= s.Length; i++)
        {
            var substring = s.Substring(index, i - index);

            if (!_hashSet.Add(substring))
            {
                continue;
            }

            var next = Dfs(i, s);

            if (next >= 0)
            {
                result = Math.Max(result, next + 1);
            }

            _hashSet.Remove(substring);
        }

        return result;
    }
}
