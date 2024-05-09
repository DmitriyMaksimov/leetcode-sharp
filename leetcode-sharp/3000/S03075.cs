namespace leetcode_sharp;

// 3075. Maximize Happiness of Selected Children
// https://leetcode.com/problems/maximize-happiness-of-selected-children
public class S03075
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        Array.Sort(happiness);
        long answer = 0;
        var count = 0;
        
        for (var i = happiness.Length - 1; i >= 0; i--)
        {
            if (k-- <= 0 || happiness[i] - count <= 0)
            {
                break;
            }

            answer += happiness[i] - count;
            count++;
        }

        return answer;
    }
}