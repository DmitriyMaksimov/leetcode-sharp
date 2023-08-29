namespace leetcode_sharp;

// 476. Number Complement
// https://leetcode.com/problems/number-complement/
public class S00476
{
    public int FindComplement(int num)
    {
        var mask = 1;
        while (mask < num)
        {
            mask = (mask << 1) + 1;
        }

        return num ^ mask;
    }
}