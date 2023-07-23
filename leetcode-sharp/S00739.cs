namespace leetcode_sharp;

// 739. Daily Temperatures
// https://leetcode.com/problems/daily-temperatures/
public class S00739
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var answer = new int[temperatures.Length];
        for (var i = 0; i < temperatures.Length; i++)
        {
            for (var j = i + 1; j < temperatures.Length; j++)
            {
                if (temperatures[j] > temperatures[i])
                {
                    answer[i] = j - i;
                    break;
                }
            }
        }
        return answer;
    }
}