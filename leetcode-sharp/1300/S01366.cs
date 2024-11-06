namespace leetcode_sharp;

// 1366. Rank Teams by Votes
// https://leetcode.com/problems/rank-teams-by-votes
public class S01366
{
    public string RankTeams(string[] votes)
    {
        var count = new List<int[]>(26);

        for (var i = 0; i < 26; i++)
        {
            count.Add(new int[27]);
            count[i][26] = 'A' + i;
        }

        foreach (var c in votes[0])
        {
            count[c - 'A'][26] = c;
        }

        foreach (var vote in votes)
        {
            for (var i = 0; i < vote.Length; i++)
            {
                count[vote[i] - 'A'][i]--;
            }
        }

        count.Sort((a, b) =>
        {
            for (var i = 0; i < 26; i++)
            {
                if (a[i] != b[i])
                {
                    return a[i].CompareTo(b[i]);
                }
            }

            return a[26].CompareTo(b[26]);
        });

        var result = "";

        for (var i = 0; i < votes[0].Length; i++)
        {
            result += (char)count[i][26];
        }

        return result;
    }
}
