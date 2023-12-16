namespace leetcode_sharp;

// 2960. Count Tested Devices After Test Operations
// https://leetcode.com/problems/count-tested-devices-after-test-operations
public class S02960
{
    public int CountTestedDevices(int[] batteryPercentages)
    {
        return batteryPercentages.Aggregate(0, (current, batteryPercentage) => current + (batteryPercentage > current ? 1 : 0));
    }
}