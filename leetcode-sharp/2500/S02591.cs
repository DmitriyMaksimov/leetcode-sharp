namespace leetcode_sharp;

// 2591. Distribute Money to Maximum Children
// https://leetcode.com/problems/distribute-money-to-maximum-children
public class S02591
{
    public int DistMoney(int money, int children)
    {
        if (money < children)
        {
            return -1;
        }

        var ans = 0;

        for (var j = 1; j <= children; j++)
        {
            var leftMoney = money - 8;
            var leftChildren = children - j;
            if (leftMoney >= leftChildren)
            {
                money = leftMoney;
                ans += 1;
            }
            else
            {
                leftChildren = children - j + 1;
                if (leftChildren == 1 && money == 4)
                {
                    ans -= 1;
                }

                money = 0;
                break;
            }
        }

        if (money > 0)
        {
            ans -= 1;
        }

        return ans;
    }
}