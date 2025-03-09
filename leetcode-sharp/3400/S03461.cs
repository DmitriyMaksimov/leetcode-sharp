namespace leetcode_sharp;

// 3461. Check If Digits Are Equal in String After Operations I
// https://leetcode.com/problems/check-if-digits-are-equal-in-string-after-operations-i
public class S03461
{
    public bool HasSameDigits(string s)
    {
        var array = s.Select(x => x - '0').ToArray();
        var n = array.Length - 1;

        for (var i = 0; i < n - 1; i++)
        {
            for (var j = 0; j < n - i; j++)
            {
                array[j] = (array[j] + array[j + 1]) % 10;
            }
        }

        return array[0] == array[1];
    }
}
