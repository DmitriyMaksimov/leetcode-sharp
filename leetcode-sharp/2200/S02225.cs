namespace leetcode_sharp;

// 2225. Find Players With Zero or One Losses
// https://leetcode.com/problems/find-players-with-zero-or-one-losses/
public class S02225
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        var loseCounts = new Dictionary<int, int>();
        var allPlayers = new HashSet<int>();

        foreach (var match in matches)
        {
            var winner = match[0];
            var loser = match[1];
            allPlayers.Add(loser);
            allPlayers.Add(winner);
            loseCounts[loser] = loseCounts.GetValueOrDefault(loser, 0) + 1;
        }

        // answer[0] is a list of all players that have not lost any matches.
        var list0 = new List<int>();
        // answer[1] is a list of all players that have lost exactly one match.
        var list1 = new List<int>();
        
        foreach (var player in allPlayers.Order())
        {
            if (loseCounts.TryGetValue(player, out var lost))
            {
                if (lost == 1) list1.Add(player);
            }
            else
            {
                list0.Add(player);
            }
        }

        return new List<IList<int>> { list0, list1 };
    }
}
