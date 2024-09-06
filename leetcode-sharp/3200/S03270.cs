namespace leetcode_sharp;

// 3270. Find the Key of the Numbers
// https://leetcode.com/problems/find-the-key-of-the-numbers
public class S03270
{
    public int GenerateKey(int num1, int num2, int num3)
    {
        var result = 0;

        for (var i = 0; i < 4; i++)
        {
            result *= 10;
            result += ((int[])[GetDigit(num1, i), GetDigit(num2, i), GetDigit(num3, i)]).Min();
        }

        return result;
    }

    private int GetDigit(int number, int n)
    {
        return number / (int)Math.Pow(10, 3 - n) % 10;
    }
}
