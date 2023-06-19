namespace leetcode_sharp;

// 2678. Number of Senior Citizens
// https://leetcode.com/problems/number-of-senior-citizens/
public class S02678
{
    public int CountSeniors(string[] details)
    {
        var result = 0;
        
        foreach (var detail in details)
        {
            var age = (detail[11] - '0') * 10 + (detail[12] - '0');
            if (age > 60)
            {
                ++result;
            }
        }
        
        return result;
    }
}