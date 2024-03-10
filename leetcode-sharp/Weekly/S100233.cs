namespace leetcode_sharp;

// 100233. Apple Redistribution into Boxes
// https://leetcode.com/contest/weekly-contest-388/problems/apple-redistribution-into-boxes/
public class S100233
{
    public int MinimumBoxes(int[] apple, int[] capacity)
    {
        var totalApples = apple.Sum();
        var result = 1;
        
        foreach (var cap in capacity.OrderDescending())
        {
            if (totalApples <= cap)
            {
                return result;
            }

            ++result;
            totalApples -= cap;
        }

        return result;
    }
}