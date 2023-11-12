namespace leetcode_sharp;

// 2739. Total Distance Traveled
// https://leetcode.com/problems/total-distance-traveled
public class S02739
{
    public int DistanceTraveled(int mainTank, int additionalTank)
    {
        var currTank = mainTank;
        var totalFuelBurnt = 0;

        while (currTank >= 5 && additionalTank > 0)
        {
            currTank -= 4;
            --additionalTank;
            totalFuelBurnt += 5;
        }

        totalFuelBurnt += currTank;
        
        return totalFuelBurnt * 10;
    }
}