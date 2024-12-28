namespace leetcode_sharp;

// 1042. Flower Planting With No Adjacent
// https://leetcode.com/problems/flower-planting-with-no-adjacent
public class S01042
{
    public int[] GardenNoAdj(int n, int[][] paths)
    {
        var result = new int[n];
        var adjacencyList = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            adjacencyList[i] = [];
        }

        foreach (var path in paths)
        {
            adjacencyList[path[0] - 1].Add(path[1] - 1);
            adjacencyList[path[1] - 1].Add(path[0] - 1);
        }

        for (var i = 0; i < n; i++)
        {
            var usedColors = new bool[5];

            foreach (var neighbor in adjacencyList[i])
            {
                usedColors[result[neighbor]] = true;
            }

            for (var flower = 1; flower <= 4; flower++)
            {
                if (!usedColors[flower])
                {
                    result[i] = flower;
                    break;
                }
            }
        }

        return result;
    }
}
