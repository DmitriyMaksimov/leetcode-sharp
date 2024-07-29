namespace leetcode_sharp;

// 1395. Count Number of Teams
// https://leetcode.com/problems/count-number-of-teams/
public class S01395
{
    public int NumTeams(int[] rating)
    {
        var result = 0;

        for (var i = 1; i < rating.Length - 1; ++i)
        {
            var less = new int[2];
            var greater = new int[2];
        
            for (var j = 0; j < rating.Length; ++j)
            {
                if (rating[i] < rating[j])
                {
                    ++less[j > i ? 1 : 0];
                }

                if (rating[i] > rating[j])
                {
                    ++greater[j > i ? 1 : 0];
                }
            }

            result += less[0] * greater[1] + greater[0] * less[1];
        }

        return result;
    }
}