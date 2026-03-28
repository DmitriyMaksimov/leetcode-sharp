namespace leetcode_sharp;

// 2573. Find the String with LCP
// https://leetcode.com/problems/find-the-string-with-lcp
public class S02573
{
    public string FindTheString(int[][] lcp)
    {
        var n = lcp.Length;
        var currentGroupId = 0;
        var groupAssignments = new int[n];

        for (var i = 0; i < n; i++)
        {
            if (groupAssignments[i] > 0)
            {
                continue;
            }

            if (++currentGroupId > 26)
            {
                return string.Empty;
            }

            for (var j = i; j < n; j++)
            {
                if (lcp[i][j] > 0)
                {
                    groupAssignments[j] = currentGroupId;
                }
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var v = i + 1 < n && j + 1 < n ? lcp[i + 1][j + 1] : 0;
                v = groupAssignments[i] == groupAssignments[j] ? v + 1 : 0;

                if (lcp[i][j] != v)
                {
                    return string.Empty;
                }
            }
        }
        
        return string.Join("", groupAssignments.Select(x => (char)('a' + x - 1)));
    }
}