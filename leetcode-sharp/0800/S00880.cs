namespace leetcode_sharp;

// 880. Decoded String at Index
// https://leetcode.com/problems/decoded-string-at-index
public class S00880
{
    public string DecodeAtIndex(string s, int k)
    {
        var size = 0L;
        var n = s.Length;

        for (var i = 0; i < n; i++)
        {
            if (char.IsDigit(s[i]))
            {
                size *= s[i] - '0';
            }
            else
            {
                size++;
            }
        }

        for (var i = n - 1; i >= 0; i--)
        {
            k = (int) (k % size);

            if (k == 0 && char.IsLetter(s[i]))
            {
                return s[i].ToString();
            }

            if (char.IsDigit(s[i]))
            {
                size /= s[i] - '0';
            }
            else
            {
                size--;
            }
        }

        return "";
    }
}