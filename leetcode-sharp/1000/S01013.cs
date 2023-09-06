namespace leetcode_sharp;

// 1013. Partition Array Into Three Parts With Equal Sum
// https://leetcode.com/problems/partition-array-into-three-parts-with-equal-sum/
public class S01013
{
    public bool CanThreePartsEqualSum(int[] arr)
    {
        var sum = arr.Sum();
        if (sum % 3 != 0)
        {
            return false;
        }

        var partSum = sum / 3;
        var partCount = 0;
        var currentSum = 0;
        
        foreach (var num in arr)
        {
            currentSum += num;
            if (currentSum == partSum)
            {
                partCount++;
                currentSum = 0;
            }
        }

        return partCount >= 3;
    }
}