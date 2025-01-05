namespace leetcode_sharp;

// 2381. Shifting Letters II
// https://leetcode.com/problems/shifting-letters-ii
public class S02381
{
    public string ShiftingLetters(string s, int[][] shifts)
    {
        var line = new long[s.Length + 1];

        foreach (var shift in shifts)
        {
            var startIndex = shift[0];
            var endIndex = shift[1];

            if (shift[2] == 1)
            {
                line[startIndex]++;
                line[endIndex + 1]--;
            }
            else
            {
                line[startIndex]--;
                line[endIndex + 1]++;
            }
        }

        for (var i = 1; i <= s.Length; i++)
        {
            line[i] += line[i - 1];
        }

        var chars = s.ToCharArray();

        for (var i = 0; i < s.Length; i++)
        {
            var increaseBy = (chars[i] - 'a' + (int)line[i]) % 26;
            increaseBy = (increaseBy + 26) % 26;
            chars[i] = (char)('a' + increaseBy);
        }

        return new string(chars);
    }
}
