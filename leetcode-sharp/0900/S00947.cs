namespace leetcode_sharp;

// 947. Most Stones Removed with Same Row or Column
// https://leetcode.com/problems/most-stones-removed-with-same-row-or-column/description/
public class S00947
{
    public int RemoveStones(int[][] stones)
    {
        var stonesLength = stones.Length;
        var visited = new bool[stonesLength];
        var count = 0;
        for (var i = 0; i < stonesLength; i++)
        {
            if (!visited[i])
            {
                dfs(stones, visited, i);
                ++count;
            }
        }
        return stonesLength - count;
    }

    private static void dfs(int[][] stones, bool[] visited, int i)
    {
        visited[i] = true;
        for (int j = 0; j < stones.Length; j++)
        {
            if (!visited[j])
            {
                if (stones[j][0] == stones[i][0] || stones[j][1] == stones[i][1])
                {
                    dfs(stones, visited, j);
                }
            }
        }
    }
}