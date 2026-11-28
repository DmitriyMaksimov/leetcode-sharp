namespace leetcode_sharp;

// 3947. Maximum Number of Items From Sale II
// https://leetcode.com/problems/maximum-number-of-items-from-sale-ii
public class S03947
{
    record Item(int Price, int Factor);

    public int MaximumSaleItems(int[][] items, int budget)
    {
        var n = items.Length;

        var cheapest = items.Min(item => item[1]);

        var have = new int[n + 1];
        var deals = Enumerable.Repeat(-1, n + 1).ToArray();

        foreach (var item in items)
        {
            have[item[0]]++;
        }

        var worth = items
            .Where(item => item[1] < 2 * cheapest)
            .Select(item => new Item(item[1], item[0]))
            .ToList();

        var heap = new PriorityQueue<Item, int>();

        foreach (var item in worth)
        {
            heap.Enqueue(item, item.Price);
        }

        var copies = 0;

        while (heap.Count > 0 && heap.Peek().Price <= budget)
        {
            var item = heap.Dequeue();

            if (deals[item.Factor] < 0)
            {
                for (var multiple = item.Factor; multiple <= n; multiple += item.Factor)
                {
                    deals[item.Factor] += have[multiple];
                }
            }

            var pairs = Math.Min(deals[item.Factor], budget / item.Price);

            copies += 2 * pairs;
            budget -= pairs * item.Price;
        }

        return copies + budget / cheapest;
    }
}