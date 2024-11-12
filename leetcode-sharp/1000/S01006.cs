namespace leetcode_sharp;

// 1006. Clumsy Factorial
// https://leetcode.com/problems/clumsy-factorial
public class S01006
{
    public int Clumsy(int n)
    {
        return n switch
        {
            <= 2 => n,
            <= 4 => n + 3,
            _ => ((n - 4) % 4) switch
            {
                0 => n + 1,
                <= 2 => n + 2,
                _ => n - 1
            }
        };
    }
}
