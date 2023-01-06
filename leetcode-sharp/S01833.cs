namespace leetcode_sharp;

// 1833. Maximum Ice Cream Bars
// https://leetcode.com/problems/maximum-ice-cream-bars/
public class S01833
{
    public int MaxIceCream(int[] costs, int coins)
    {
        Array.Sort(costs);
        for (int i = 0; i < costs.Length; i++)
        {
            if (costs[i] > coins)
            {
                return i;
            }

            coins -= costs[i];
        }
        
        return costs.Length;
    }
}