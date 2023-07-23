namespace leetcode_sharp;

// 415. Add Strings
// https://leetcode.com/problems/add-strings/
public class S00415
{
    public string AddStrings(string num1, string num2)
    {
        var aIndex = num1.Length - 1;
        var bIndex = num2.Length - 1;
        var carry = 0;
        var result = "";

        while (aIndex >= 0 || bIndex >= 0)
        {
            var aDigit = int.Parse((aIndex >= 0 ? num1[aIndex] : '0').ToString());
            var bDigit = int.Parse((bIndex >= 0 ? num2[bIndex] : '0').ToString());

            var sum = aDigit + bDigit + carry;
            if (sum > 9)
            {
                sum %= 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            result += (char)('0' + sum);
            
            aIndex--;
            bIndex--;
        }

        if (carry != 0)
        {
            result += '1';
        }
        
        return string.Join("", result.Reverse());
    }
}