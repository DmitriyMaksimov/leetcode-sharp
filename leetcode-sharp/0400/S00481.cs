namespace leetcode_sharp;

// 481. Magical String
// https://leetcode.com/problems/magical-string
public class S00481
{
    public int MagicalString(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        if (n <= 3)
        {
            return 1;
        }

        var sequence = new int[n + 1];

        sequence[0] = 1;
        sequence[1] = 2;
        sequence[2] = 2;

        var head = 2;
        var tail = 3;
        var currentNumber = 1;
        var result = 1;

        while (tail < n)
        {
            for (var i = 0; i < sequence[head]; i++)
            {
                sequence[tail] = currentNumber;

                if (currentNumber == 1 && tail < n)
                {
                    result++;
                }

                tail++;
            }

            currentNumber = currentNumber == 1  ? 2 : 1;
            head++;
        }

        return result;
    }
}
