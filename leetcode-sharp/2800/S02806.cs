namespace leetcode_sharp;

// 2806. Account Balance After Rounded Purchase
// https://leetcode.com/problems/account-balance-after-rounded-purchase
public class S02806
{
    public int AccountBalanceAfterPurchase(int purchaseAmount)
    {
        var reminder = purchaseAmount % 10;
        
        purchaseAmount = reminder is >= 0 and < 5 ? purchaseAmount - reminder : purchaseAmount + 10 - reminder;

        return 100 - purchaseAmount;
    }
}