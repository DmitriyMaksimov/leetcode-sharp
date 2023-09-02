namespace leetcode_sharp;

// 599. Minimum Index Sum of Two Lists
// https://leetcode.com/problems/minimum-index-sum-of-two-lists/
public class S00599
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var commonStrings = list1.Intersect(list2);
        var indexSums = commonStrings.Select(x =>
            new {name = x, sum = Array.IndexOf(list1, x) + Array.IndexOf(list2, x)}
        );
        var minIndexSum = indexSums.Min(x => x.sum);

        return indexSums
            .Where(x => x.sum == minIndexSum)
            .Select(x => x.name)
            .ToArray();
    }
}