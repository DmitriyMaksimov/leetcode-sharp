namespace leetcode_sharp;

// 396. Rotate Function
// https://leetcode.com/problems/rotate-function
public class S00396
{
    public int MaxRotateFunction(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var totalSum = 0;
        var initialRotationValue = 0;
        var maxRotationValue = int.MinValue;

        for (var index = 0; index < nums.Length; index++)
        {
            totalSum += nums[index];
            initialRotationValue += index * nums[index];
        }

        var rotationValues = new int[nums.Length];
        rotationValues[0] = initialRotationValue;
        maxRotationValue = rotationValues[0];

        for (var rotation = 1; rotation < nums.Length; rotation++)
        {
            rotationValues[rotation] = rotationValues[rotation - 1] + totalSum - nums.Length * nums[^rotation];
            maxRotationValue = Math.Max(maxRotationValue, rotationValues[rotation]);
        }

        return maxRotationValue;
    }
}