namespace leetcode_sharp;

// 638. Shopping Offers
// https://leetcode.com/problems/shopping-offers
public class S00638
{
    private readonly Dictionary<string, int> _memo = [];

    public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
    {
        return Dfs(needs, price, special, needs);
    }

    private int Dfs(IList<int> currentNeeds, IList<int> price, IList<IList<int>> special, IList<int> needs)
    {
        var key = string.Join(",", currentNeeds);

        if (_memo.TryGetValue(key, out var value))
        {
            return value;
        }

        var cost = currentNeeds.Select((t, i) => t * price[i]).Sum();

        foreach (var spec in special)
        {
            var tmpNeeds = new List<int>();
            var valid = true;

            for (var i = 0; i < needs.Count; i++)
            {
                tmpNeeds.Add(currentNeeds[i] - spec[i]);
                if (tmpNeeds[i] < 0)
                {
                    valid = false;
                }
            }

            if (valid)
            {
                cost = Math.Min(cost, Dfs(tmpNeeds, price, special, needs) + spec[^1]);
            }
        }

        return _memo[key] = cost;
    }
}
