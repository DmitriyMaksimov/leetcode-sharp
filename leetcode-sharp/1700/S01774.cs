namespace leetcode_sharp;

// 1774. Closest Dessert Cost
// https://leetcode.com/problems/closest-dessert-cost
public class S01774
{
    private int _closest;

    public int ClosestCost(int[] baseCosts, int[] toppingCosts, int target)
    {
        _closest = baseCosts[0];

        foreach (var baseCost in baseCosts)
        {
            ExploreToppings(baseCost, toppingCosts, 0, target);
        }

        return _closest;
    }

    private void ExploreToppings(int currentCost, int[] toppings, int index, int target)
    {
        if (Math.Abs(target - currentCost) < Math.Abs(target - _closest) || (Math.Abs(target - currentCost) == Math.Abs(target - _closest) && currentCost < _closest))
        {
            _closest = currentCost;
        }

        if (index == toppings.Length || currentCost >= target)
        {
            return;
        }

        ExploreToppings(currentCost, toppings, index + 1, target);
        ExploreToppings(currentCost + toppings[index], toppings, index + 1, target);
        ExploreToppings(currentCost + toppings[index] * 2, toppings, index + 1, target);
    }
}