namespace leetcode_sharp;

// 925. Long Pressed Name
// https://leetcode.com/problems/long-pressed-name/
public class S00925
{
    public bool IsLongPressedName(string name, string typed)
    {
        var nameLength = name.Length;
        var typedLength = typed.Length;
        var i = 0;

        for (var j = 0; j < typedLength; ++j)
        {
            if (i < nameLength && name[i] == typed[j])
            {
                ++i;
            }
            else if (j == 0 || typed[j] != typed[j - 1])
            {
                return false;
            }
        }

        return i == nameLength;
    }
}