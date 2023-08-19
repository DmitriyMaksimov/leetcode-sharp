namespace leetcode_sharp;

// 1615. Maximal Network Rank
// https://leetcode.com/problems/maximal-network-rank/
public class S01615
{
    public int MaximalNetworkRank(int n, int[][] roads)
    {
        var degree = new int[n];
        var roadSet = new HashSet<string>();

        foreach (var road in roads)
        {
            degree[road[0]]++;
            degree[road[1]]++;
            roadSet.Add($"{road[0]}_{road[1]}");
            roadSet.Add($"{road[1]}_{road[0]}");
        }

        var maxRank = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                var rank = degree[i] + degree[j];
                if (roadSet.Contains($"{i}_{j}"))
                {
                    rank--;
                }

                maxRank = Math.Max(maxRank, rank);
            }
        }

        return maxRank;
    }
}