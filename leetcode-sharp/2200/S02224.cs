namespace leetcode_sharp;

// 2224. Minimum Number of Operations to Convert Time
// https://leetcode.com/problems/minimum-number-of-operations-to-convert-time
public class S02224
{
    public int ConvertTime(string current, string correct)
    {
        var d = convertToMinutes(correct) - convertToMinutes(current);

        return d / 60 + d % 60 / 15 + d % 15 / 5 + d % 5;
    }

    private static int convertToMinutes(string s)
    {
        return (s[0] * 10 + s[1]) * 60 + s[3] * 10 + s[4];
    }
}