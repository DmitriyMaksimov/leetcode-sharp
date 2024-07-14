namespace leetcode_sharp;

// 3184. Count Pairs That Form a Complete Day I
// https://leetcode.com/problems/count-pairs-that-form-a-complete-day-i
public class S03184
{
    public int CountCompleteDayPairs(int[] hours)
    {
        var result = 0;

        for (var i = 0; i < hours.Length - 1; i++)
        {
            for (var j = i + 1; j < hours.Length; j++)
            {
                if ((hours[i] + hours[j]) % 24 == 0)
                {
                    ++result;
                }
            }
            
        }
        
        return result;
    }
}