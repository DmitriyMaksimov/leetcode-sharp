namespace leetcode_sharp;

// 3100. Water Bottles II
// https://leetcode.com/problems/water-bottles-ii
public class S03100
{
    public int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        var sum = numBottles;
        var bottle = numBottles;

        while (bottle >= numExchange)
        {
            bottle -= numExchange++;
            sum++;
            bottle++;
        }

        return sum;
    }
}
