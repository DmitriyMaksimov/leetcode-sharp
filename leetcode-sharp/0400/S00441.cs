namespace leetcode_sharp;

// 441. Arranging Coins
// https://leetcode.com/problems/arranging-coins/
public class S00441
{
    public int ArrangeCoins(int n)
    {
        return (int)(Math.Sqrt(2 * (long)n + 0.25) - 0.5);
    }
}