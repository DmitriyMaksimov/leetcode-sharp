namespace leetcode_sharp;

// 860. Lemonade Change
// https://leetcode.com/problems/lemonade-change/
public class S00860
{
    public bool LemonadeChange(int[] bills)
    {
        var five = 0;
        var ten = 0;

        foreach (var bill in bills)
        {
            switch (bill)
            {
                case 5:
                    five++;
                    break;
                case 10:
                    if (five == 0)
                    {
                        return false;
                    }

                    five--;
                    ten++;
                    break;
                case 20:
                    if (five == 0)
                    {
                        return false;
                    }

                    if (ten > 0)
                    {
                        ten--;
                        five--;
                    }
                    else if (five >= 3)
                    {
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }

                    break;
            }
        }

        return true;
    }
}