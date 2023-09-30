namespace leetcode_sharp;

// 2566. Maximum Difference by Remapping a Digit
// https://leetcode.com/problems/maximum-difference-by-remapping-a-digit
public class S02566
{
    public int MinMaxDifference(int num)
    {
        var chars = num.ToString().ToCharArray();
        var idx = -1;

        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] != '9')
            {
                idx = i;
                break;
            }
        }

        if (idx == -1) return num;
        
        var max = int.Parse(num.ToString().Replace("" + chars[idx], "9"));
        var min = int.Parse(num.ToString().Replace("" + chars[0], "0"));
        
        return max - min;
    }
}