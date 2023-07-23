namespace leetcode_sharp;

// 2710. Remove Trailing Zeros From a String
// https://leetcode.com/problems/remove-trailing-zeros-from-a-string/
public class S02710
{
    public string RemoveTrailingZeros(string num)
    {
        var index = num.Length - 1;

        while (num[index] == '0')
        {
            --index;
        }

        return num[..(index + 1)];
    }
}