namespace leetcode_sharp;

// 3005. Count Elements With Maximum Frequency
// https://leetcode.com/problems/count-elements-with-maximum-frequency
public class S03005
{
    public int MaxFrequencyElements(int[] nums)
    {
        const int maxElements = 100;
        var frequencies = new int[maxElements + 1];
        var maxFrequency = 0;
        
        foreach (var num in nums)
        {
            if (++frequencies[num] > maxFrequency)
            {
                maxFrequency = frequencies[num];
            }
        }
        
        return frequencies.Count(x => x== maxFrequency) * maxFrequency;
    }
}