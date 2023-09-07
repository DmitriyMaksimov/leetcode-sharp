namespace leetcode_sharp;

// 1103. Distribute Candies to People
// https://leetcode.com/problems/distribute-candies-to-people/
public class S01103
{
    public int[] DistributeCandies(int candies, int num_people)
    {
        var result = new int[num_people];

        for (var i = 0; candies > 0; i++)
        {
            result[i % num_people] += Math.Min(candies, i + 1);
            candies -= i + 1;
        }

        return result;
    }
}