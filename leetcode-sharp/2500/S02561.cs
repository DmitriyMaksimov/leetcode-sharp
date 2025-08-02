namespace leetcode_sharp;

// 2561. Rearranging Fruits
// https://leetcode.com/problems/rearranging-fruits
public class S02561
{
    public long MinCost(int[] basket1, int[] basket2)
    {
        var count = new Dictionary<int, int>();

        foreach (var c in basket1)
        {
            count[c] = count.GetValueOrDefault(c) + 1;
        }

        foreach (var c in basket2)
        {
            count[c] = count.GetValueOrDefault(c) - 1;
        }

        var transfers = new List<int>();

        foreach (var (key, value) in count)
        {
            if (value % 2 != 0)
            {
                return -1;
            }

            for (var i = 0; i < Math.Abs(value) / 2; i++)
            {
                transfers.Add(key);
            }
        }

        var minItem = Math.Min(basket1.Min(), basket2.Min());

        transfers.Sort();

        var totalCost = 0L;
        
        for (var i = 0; i < transfers.Count / 2; i++)
        {
            totalCost += Math.Min(transfers[i], minItem * 2);
        }

        return totalCost;
    }
}