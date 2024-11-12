namespace leetcode_sharp;

// 2070. Most Beautiful Item for Each Query
// https://leetcode.com/problems/most-beautiful-item-for-each-query
public class S02070
{
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {
        var result = new int[queries.Length];
        var queriesPair = queries.Select((int query, int index) => (query, index)).ToList();
        queriesPair.Sort((a, b) => a.query.CompareTo(b.query));
        Array.Sort(items, (a, b) => a[0].CompareTo(b[0]));

        var itemIndex = 0;
        var maxBeauty = 0;

        foreach (var (maxPriceAllowed, queryOriginalIndex) in queriesPair)
        {
            while (itemIndex < items.Length && items[itemIndex][0] <= maxPriceAllowed)
            {
                maxBeauty = Math.Max(maxBeauty, items[itemIndex][1]);
                itemIndex++;
            }

            result[queryOriginalIndex] = maxBeauty;
        }

        return result;
    }
}