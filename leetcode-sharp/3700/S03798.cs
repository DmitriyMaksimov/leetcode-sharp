namespace leetcode_sharp;

// 3798. Largest Even Number
// https://leetcode.com/problems/largest-even-number
public class S03798
{
    public string LargestEven(string s)
    {
        var lastEvenIndex = s.LastIndexOf('2');
        return lastEvenIndex == -1 ? "" : s[..(lastEvenIndex + 1)];
    }
}