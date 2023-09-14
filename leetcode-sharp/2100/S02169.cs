namespace leetcode_sharp;

// 2169. Count Operations to Obtain Zero
// https://leetcode.com/problems/count-operations-to-obtain-zero/
public class S02169
{
    public int CountOperations(int num1, int num2)
    {
        var count = 0;

        while (num1 > 0 && num2 > 0)
        {
            if (num1 >= num2)
            {
                num1 -= num2;
            }
            else
            {
                num2 -= num1;
            }

            count++;
        }

        return count;
    }
}