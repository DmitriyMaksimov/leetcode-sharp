namespace leetcode_sharp;

// 3174. Clear Digits
// https://leetcode.com/problems/clear-digits
public class S03174
{
    public string ClearDigits(string s)
    {
        var charArray = s.ToCharArray();
        var j = 0;
        for (var i = 0; i < charArray.Length; ++i)
        {
            if (char.IsDigit(charArray[i]))
            {
                j--;
            }
            else
            {
                charArray[j++] = charArray[i];
            }
        }

        return string.Join("", charArray[..j]);
    }
}