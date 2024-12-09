namespace leetcode_sharp;

// 1423. Maximum Points You Can Obtain from Cards
// https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards
public class S01423
{
    public int MaxScore(int[] cardPoints, int k)
    {
        var total = cardPoints.Take(k).Sum();
        var result = total;

        for (int i = k - 1, j = cardPoints.Length - 1; i >= 0; i--, j--)
        {
            total += cardPoints[j] - cardPoints[i];
            result = Math.Max(result, total);
        }

        return result;
    }
}
