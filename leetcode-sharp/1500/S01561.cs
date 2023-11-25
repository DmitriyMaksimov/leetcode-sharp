namespace leetcode_sharp;

// 1561. Maximum Number of Coins You Can Get
// https://leetcode.com/problems/maximum-number-of-coins-you-can-get
public class S01561
{
    public int MaxCoins(int[] piles)
    {
        Array.Sort(piles);
        
        var ans = 0;
        
        for (int i = 0, j = piles.Length - 2; i < j; i++, j -= 2)
        {
            ans += piles[j];
        }

        return ans;
    }
}