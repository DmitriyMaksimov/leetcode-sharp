namespace leetcode_sharp;

// 67. Add Binary
// https://leetcode.com/problems/add-binary/
public class S00067
{
    public string AddBinary(string a, string b)
    {
        var aIndex = a.Length - 1;
        var bIndex = b.Length - 1;
        var carry = 0;
        var result = "";

        while (aIndex >= 0 || bIndex >= 0)
        {
            var aDigit = int.Parse((aIndex >= 0 ? a[aIndex] : '0').ToString());
            var bDigit = int.Parse((bIndex >= 0 ? b[bIndex] : '0').ToString());

            var sum = aDigit + bDigit + carry;
            if (sum > 1)
            {
                sum = sum > 2 ? 1 : 0;
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