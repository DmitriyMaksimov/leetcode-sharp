namespace leetcode_sharp;

// 575. Distribute Candies
// https://leetcode.com/problems/distribute-candies/
public class S00575
{
    public int DistributeCandies(int[] candyType)
    {
        var set = new HashSet<int>();
        foreach (var candy in candyType)
        {
            set.Add(candy);
        }

        return Math.Min(set.Count, candyType.Length / 2);
    }
}