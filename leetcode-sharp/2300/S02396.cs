namespace leetcode_sharp;

// 2396. Strictly Palindromic Number
// https://leetcode.com/problems/strictly-palindromic-number/
public class S02396
{
    private static int[] convertToBase(int value, int toBase)
    {
        var retVal = new List<int>();

        while (value > 0)
        {
            retVal.Add(value % toBase);
            value /= toBase;
        }

        return retVal.ToArray();
    }
    
    public bool IsStrictlyPalindromic(int n)
    {
        for (var toBase = 2; toBase <= n - 2; toBase++)
        {
            var val = convertToBase(n, toBase);
            if (!val.SequenceEqual(val.AsEnumerable().Reverse())) return false;
        }
        return true;
    }
}