namespace leetcode_sharp;

// 859. Buddy Strings
// https://leetcode.com/problems/buddy-strings/
public class S00859
{
    public bool BuddyStrings(string s, string goal)
    {
        if (s.Length != goal.Length || s.Length == 1)
        {
            return false;
        }

        var diffIndexes = new List<int>();
        var charCounts = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            charCounts[s[i]] = charCounts.GetValueOrDefault(s[i]) + 1;

            if (s[i] != goal[i])
            {
                diffIndexes.Add(i);
                if (diffIndexes.Count > 2)
                {
                    return false;
                }
            }
        }

        if (diffIndexes.Count == 1)
        {
            return false;
        }

        if (diffIndexes.Count == 0)
        {
            return charCounts.Any(x => x.Value >= 2);
        }

        var index1 = diffIndexes[0];
        var index2 = diffIndexes[1];

        return (s[index1] == goal[index1] && s[index2] == goal[index2]) || (s[index1] == goal[index2] && s[index2] == goal[index1]);
    }
}