namespace leetcode_sharp;

// 3046. Split the Array
// https://leetcode.com/problems/split-the-array/
public class S03046
{
    public bool IsPossibleToSplit(int[] nums)
    {
        Dictionary<int, int> frequency = [];

        foreach (var num in nums)
        {
            frequency[num] = frequency.GetValueOrDefault(num) + 1;
            if (frequency[num] > 2)
            {
                return false;
            }
        }
        
        return true;
    }
}