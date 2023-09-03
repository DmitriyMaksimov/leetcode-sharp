namespace leetcode_sharp;

// 830. Positions of Large Groups
// https://leetcode.com/problems/positions-of-large-groups/
public class S00830
{
    public IList<IList<int>> LargeGroupPositions(string s)
    {
        var result = new List<IList<int>>();
        var start = 0;
        var end = 0;
        var prev = s[0];

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == prev)
            {
                end = i;
            }
            else
            {
                if (end - start >= 2)
                {
                    result.Add(new List<int> {start, end});
                }

                start = i;
                end = i;
                prev = s[i];
            }
        }

        if (end - start >= 2)
        {
            result.Add(new List<int> {start, end});
        }

        return result;
    }
}