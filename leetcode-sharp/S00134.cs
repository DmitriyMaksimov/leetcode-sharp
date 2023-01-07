namespace leetcode_sharp;

// 134. Gas Station
// https://leetcode.com/problems/gas-station/
public class S00134
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var totalSurplus = 0;
        var currentFuelLLevel = 0;
        var result = 0;

        for (var i = 0; i < gas.Length; i++)
        {
            totalSurplus += gas[i] - cost[i];
            currentFuelLLevel += gas[i] - cost[i];

            if (currentFuelLLevel < 0)
            {
                // We can't make it => set starting point to i + 1
                currentFuelLLevel = 0;
                result = i + 1;
            }
        }

        return totalSurplus < 0 ? -1 : result;
    }
}