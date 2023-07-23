namespace leetcode_sharp;

// 1791. Find Center of Star Graph
// https://leetcode.com/problems/find-center-of-star-graph/
public class S01791
{
    public int FindCenter(int[][] edges)
    {
        var nodes = new[]{ edges[0][0], edges[0][1], edges[1][0], edges[1][1]};

        for (var i = 0; i < nodes.Length; i++)
        {
            for (var j = 0; j < nodes.Length; j++)
            {
                if (i != j && nodes[i] == nodes[j])
                {
                    return nodes[i];
                }
            }
        }

        return 0;
    }
}