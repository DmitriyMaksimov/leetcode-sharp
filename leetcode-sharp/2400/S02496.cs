namespace leetcode_sharp;

// 2496. Maximum Value of a String in an Array
// https://leetcode.com/problems/maximum-value-of-a-string-in-an-array/
public class S02496
{
    public int MaximumValue(string[] strs)
    {
        var result = 0;
        
        foreach (var str in strs)
        {
            result = Math.Max(result, str.All(char.IsDigit) ? int.Parse(str) : str.Length);
        }

        return result;
    }
}