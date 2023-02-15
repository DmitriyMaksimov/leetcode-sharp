namespace leetcode_sharp;

// 989. Add to Array-Form of Integer
// https://leetcode.com/problems/add-to-array-form-of-integer/
public class S00989
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var result = new List<int>();
        var aIndex = num.Length - 1;
        var num2 = new List<int>();
        while (k > 0)
        {
            num2.Add(k % 10);
            k /= 10;
        }
        var bIndex = 0;
        var carry = 0;

        while (aIndex >= 0 || bIndex < num2.Count)
        {
            var aDigit = aIndex >= 0 ? num[aIndex] : 0;
            var bDigit = bIndex < num2.Count ? num2[bIndex] : 0;

            var sum = aDigit + bDigit + carry;
            if (sum > 9)
            {
                carry = 1;
                sum %= 10;
            }
            else
            {
                carry = 0;
            }

            result.Add(sum);
            
            aIndex--;
            bIndex++;
        }

        if (carry != 0)
        {
            result.Add(carry);
        }

        result.Reverse();
            
        return result;
    }
}