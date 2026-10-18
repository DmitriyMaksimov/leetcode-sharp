namespace leetcode_sharp;

// 3992. Rearrange String to Avoid Character Pair
// https://leetcode.com/problems/rearrange-string-to-avoid-character-pair
public class S03992
{
    public string RearrangeString(string s, char x, char y)
    {
        var countX = 0;
        var result = new char[s.Length];
        var currentIndex = 0;

        foreach (var ch in s)
        {
            if (ch == x)
            {
                countX++;
            }
            else if (ch != y)
            {
                result[currentIndex++] = ch;
            }
        }

        var countY = s.Length - currentIndex - countX;
        
        while (countY-- > 0)
        {
            result[currentIndex++] = y;
        }

        while (countX-- > 0)
        {
            result[currentIndex++] = x;
        }

        return new string(result);
    }
}