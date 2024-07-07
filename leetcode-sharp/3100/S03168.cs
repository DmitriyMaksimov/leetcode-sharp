namespace leetcode_sharp;

// 3168. Minimum Number of Chairs in a Waiting Room
// https://leetcode.com/problems/minimum-number-of-chairs-in-a-waiting-room
public class S03168
{
    public int MinimumChairs(string s)
    {
        var result = 0;
        var persons = 0;
        
        foreach (var c in s)
        {
            if (c == 'E')
            {
                ++persons;
            }
            else
            {
                --persons;
            }

            result = Math.Max(result, persons);
        }
        
        return result;
    }
}