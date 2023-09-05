namespace leetcode_sharp;

// 925. Long Pressed Name
// https://leetcode.com/problems/long-pressed-name/
public class S00925
{
    public bool IsLongPressedName(string name, string typed)
    {
        var i = 0;
        var j = 0;
        
        while (i < name.Length && j < typed.Length)
        {
            if (name[i] == typed[j])
            {
                i++;
                j++;
            }
            else if (j > 0 && typed[j] == typed[j - 1])
            {
                j++;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}