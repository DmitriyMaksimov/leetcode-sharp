namespace leetcode_sharp;

// 2363. Merge Similar Items
// https://leetcode.com/problems/merge-similar-items/
public class S02363
{
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
    {
        // Create a dictionary to keep track of values and summed weights
        var valueWeights = new Dictionary<int, int>();

        AddToDictionary(items1);
        AddToDictionary(items2);

        return valueWeights.OrderBy(x => x.Key).Select(pair => new[] {pair.Key, pair.Value}).Cast<IList<int>>().ToList();

        void AddToDictionary(int[][] items)
        {
            foreach (var item in items)
            {
                valueWeights.TryAdd(item[0], 0);
                valueWeights[item[0]] += item[1];
            }
        }
    }
}