namespace leetcode_sharp;

// 458. Poor Pigs
// https://leetcode.com/problems/poor-pigs
public class S00458
{
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
    {
        // ReSharper disable once PossibleLossOfFraction
        return (int)Math.Ceiling(Math.Log2(buckets) / Math.Log2(minutesToTest / minutesToDie + 1));
    }
}