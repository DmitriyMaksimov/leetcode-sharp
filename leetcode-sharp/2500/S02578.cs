namespace leetcode_sharp;

// 2578. Split With Minimum Sum
// https://leetcode.com/problems/split-with-minimum-sum/
public class S02578
{
    public int SplitNum(int num)
    {
        var chars = num.ToString().OrderBy(x => x).ToArray();

        var n1 = 0;
        var n2 = 0;

        for (var i = 0; i < chars.Length; i++)
        {
            if (i % 2 == 0)
            {
                n1 = n1 * 10 + chars[i] - '0';
            }
            else
            {
                n2 = n2 * 10 + chars[i] - '0';
            }
        }
        
        return n1 + n2;
    }
}