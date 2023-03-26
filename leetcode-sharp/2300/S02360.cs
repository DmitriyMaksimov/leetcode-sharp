namespace leetcode_sharp;

// 2360. Longest Cycle in a Graph
// https://leetcode.com/problems/longest-cycle-in-a-graph/
public class S02360
{
    public int LongestCycle(int[] edges)
    {
        var result = -1;
        var memo = new List<(int, int)>(Enumerable.Repeat((-1, -1), edges.Length));

        for (var i = 0; i < edges.Length; ++i)
        {
            var currentDistance = 0;
            
            for (var j = i; j != -1; j = edges[j])
            {
                var (distance, startIndex) = memo[j];
                if (distance == -1)
                {
                    memo[j] = (currentDistance++, i);
                }
                else
                {
                    if (startIndex == i)
                    {
                        // Found cycle => record the result
                        result = Math.Max(result, currentDistance - distance);
                    }

                    break;
                }
            }
        }

        return result;
    }
}