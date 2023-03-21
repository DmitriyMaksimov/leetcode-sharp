namespace leetcode_sharp;

// 264. Ugly Number II
// https://leetcode.com/problems/ugly-number-ii/
public class S00264
{
    public int NthUglyNumber(int n)
    {
        var uglyNumbers = new List<int>(n) {1};
        var index2 = 0;
        var index3 = 0;
        var index5 = 0;

        for (var i = 1; i < n; i++)
        {
            var uglyNumber2 = uglyNumbers[index2] * 2;
            var uglyNumber3 = uglyNumbers[index3] * 3;
            var uglyNumber5 = uglyNumbers[index5] * 5;
            
            uglyNumbers.Add(min(uglyNumber2, uglyNumber3, uglyNumber5));
            
            if (uglyNumbers[i] == uglyNumber2) index2++;
            if (uglyNumbers[i] == uglyNumber3) index3++;
            if (uglyNumbers[i] == uglyNumber5) index5++;
        }

        return uglyNumbers[n - 1];
    }

    private static int min(params int[] numbers)
    {
        var result = numbers[0];

        for (var i = 1; i < numbers.Length; i++)
        {
            result = Math.Min(result, numbers[i]);
        }

        return result;
    }
}