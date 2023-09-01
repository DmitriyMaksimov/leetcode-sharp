namespace leetcode_sharp;

// 575. Distribute Candies
// https://leetcode.com/problems/distribute-candies/
public class S00575
{
    public int DistributeCandies(int[] candyType)
    {
        return Math.Min(candyType.Distinct().Count(), candyType.Length / 2);
    }
}