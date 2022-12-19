namespace leetcode_sharp;

// 167. Two Sum II - Input Array Is Sorted
// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
public class S00167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (var i = 0; i < numbers.Length; i++)
        {
            var index = Array.BinarySearch(numbers, i + 1, numbers.Length - i - 1, target - numbers[i]);
            if (index >= 0)
            {
                return new[] {i + 1, index + 1};
            }
        }

        return new[] {-1, -1};
    }
}