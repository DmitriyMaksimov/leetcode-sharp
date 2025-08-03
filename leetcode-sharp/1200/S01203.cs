namespace leetcode_sharp;

// 1203. Sort Items by Groups Respecting Dependencies
// https://leetcode.com/problems/sort-items-by-groups-respecting-dependencies/
public class S01203
{
    public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
    {
        var groupId = m;
        for (var i = 0; i < n; i++)
        {
            if (group[i] == -1)
            {
                group[i] = groupId;
                groupId++;
            }
        }

        var itemGraph = new Dictionary<int, List<int>>();
        var itemIndegree = new int[n];
        for (var i = 0; i < n; ++i)
        {
            itemGraph.Add(i, []);
        }

        var groupGraph = new Dictionary<int, List<int>>();
        var groupIndegree = new int[groupId];
        for (var i = 0; i < groupId; ++i)
        {
            groupGraph.Add(i, []);
        }

        for (var curr = 0; curr < n; curr++)
        {
            foreach (var prev in beforeItems[curr])
            {
                itemGraph[prev].Add(curr);
                itemIndegree[curr]++;

                if (group[curr] != group[prev])
                {
                    groupGraph[group[prev]].Add(group[curr]);
                    groupIndegree[group[curr]]++;
                }
            }
        }

        var itemOrder = topologicalSort(itemGraph, itemIndegree);
        var groupOrder = topologicalSort(groupGraph, groupIndegree);

        if (!itemOrder.Any() || !groupOrder.Any())
        {
            return [];
        }

        var orderedGroups = new Dictionary<int, List<int>>();
        
        foreach (var item in itemOrder)
        {
            orderedGroups[group[item]] = orderedGroups.GetValueOrDefault(group[item], []);
            orderedGroups[group[item]].Add(item);
        }

        var answerList = new List<int>();
        foreach (var groupIndex in groupOrder)
        {
            answerList.AddRange(orderedGroups.GetValueOrDefault(groupIndex, []));
        }

        return answerList.ToArray();
    }

    private List<int> topologicalSort(Dictionary<int, List<int>> graph, int[] indegree)
    {
        var visited = new List<int>();
        var stack = new Stack<int>();
        foreach (var key in graph.Keys.Where(key => indegree[key] == 0))
        {
            stack.Push(key);
        }

        while (stack.Any())
        {
            var curr = stack.Pop();
            visited.Add(curr);
            
            foreach (var prev in graph[curr])
            {
                indegree[prev]--;
                if (indegree[prev] == 0)
                {
                    stack.Push(prev);
                }
            }
        }

        return visited.Count == graph.Count ? visited : [];
    }
}