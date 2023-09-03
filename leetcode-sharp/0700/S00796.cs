namespace leetcode_sharp;

// 796. Rotate String
// https://leetcode.com/problems/rotate-string/
public class S00796
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
        {
            return false;
        }

        if (s.Length == 0)
        {
            return true;
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] != goal[0]) continue;
            
            var j = 0;
            for (; j < goal.Length; j++)
            {
                if (s[(i + j) % s.Length] != goal[j])
                {
                    break;
                }
            }

            if (j == goal.Length)
            {
                return true;
            }
        }

        return false;
    }
}