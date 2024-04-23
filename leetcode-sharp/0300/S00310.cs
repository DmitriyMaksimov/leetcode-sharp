namespace leetcode_sharp;

// 310. Minimum Height Trees
// https://leetcode.com/problems/minimum-height-trees
public class S00310
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1)
        {
            return [0];
        }
        
        List<List<int>> myGraph = [];
        
        var degree = new int[n];
        for (var i = 0; i < n; i++)
        {
            myGraph.Add([]);
        }

        foreach (var edge in edges)
        {
            myGraph[edge[0]].Add(edge[1]);
            myGraph[edge[1]].Add(edge[0]);
            degree[edge[0]]++;
            degree[edge[1]]++;
        }

        Queue<int> myQueue = [];

        for (var i = 0; i < n; i++)
        {
            switch (degree[i])
            {
                case 0:
                    return [];
                case 1:
                    myQueue.Enqueue(i);
                    break;
            }
        }

        List<int> result = [];

        while (myQueue.Count != 0)
        {
            result = [];
            var count = myQueue.Count;

            for (var i = 0; i < count; i++)
            {
                var curr = myQueue.Dequeue();
                result.Add(curr);
                degree[curr]--;
                for (var k = 0; k < myGraph[curr].Count; k++)
                {
                    var next = myGraph[curr][k];
                    switch (degree[next])
                    {
                        case 0:
                            continue;
                        case 2:
                            myQueue.Enqueue(next);
                            break;
                    }

                    degree[next]--;
                }
            }
        }

        return result;
    }
}