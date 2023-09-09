namespace leetcode_sharp;

// 1518. Water Bottles
// https://leetcode.com/problems/water-bottles/
public class S01518
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        var result = numBottles;
        var emptyBottles = numBottles;
        
        while (emptyBottles >= numExchange)
        {
            var newBottles = emptyBottles / numExchange;
            result += newBottles;
            emptyBottles = emptyBottles % numExchange + newBottles;
        }

        return result;
    }
}