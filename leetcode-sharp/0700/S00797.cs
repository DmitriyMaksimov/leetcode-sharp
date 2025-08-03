namespace leetcode_sharp;

// 797. All Paths From Source to Target
// https://leetcode.com/problems/all-paths-from-source-to-target/
public class S00797
{
    private readonly List<IList<int>> _result = [];
    
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        dfs(graph, 0, [0]);
        
        return _result;
    }

    private void dfs(int[][] graph, int node, List<int> currentPath)
    {
        foreach (var i in graph[node])
        {
            if (i == graph.Length - 1)
            {
                // Found path
                currentPath.Add(i);
                _result.Add(currentPath.ToArray());
                currentPath.Remove(i);
                continue;
            }

            currentPath.Add(i);
            dfs(graph, i, currentPath);
            currentPath.Remove(i);
        }
    }
}