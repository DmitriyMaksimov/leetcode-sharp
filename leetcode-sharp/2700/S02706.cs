namespace leetcode_sharp;

// 2706. Buy Two Chocolates
// https://leetcode.com/problems/buy-two-chocolates
public class S02706
{
    public int BuyChoco(int[] prices, int money)
    {
        var smallestPrice = int.MaxValue;
        var secondSmallestPrice = int.MaxValue;

        foreach (var price in prices)
        {
            if (smallestPrice > price)
            {
                secondSmallestPrice = smallestPrice;
                smallestPrice = price;
            }
            else if (secondSmallestPrice > price)
            {
                secondSmallestPrice = price;
            }
        }

        var minMoneyForTwoChocolates = smallestPrice + secondSmallestPrice;
        
        return minMoneyForTwoChocolates <= money ? money - minMoneyForTwoChocolates : money;
    }
}