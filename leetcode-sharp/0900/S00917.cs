namespace leetcode_sharp;

// 917. Reverse Only Letters
// https://leetcode.com/problems/reverse-only-letters/
public class S00917
{
    public string ReverseOnlyLetters(string s)
    {
        var chars = s.ToCharArray();
        var left = 0;
        var right = chars.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetter(chars[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetter(chars[right]))
            {
                right--;
            }

            if (left < right)
            {
                (chars[left], chars[right]) = (chars[right], chars[left]);
                left++;
                right--;
            }
        }

        return new string(chars);
    }
}