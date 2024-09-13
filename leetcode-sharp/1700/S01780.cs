namespace leetcode_sharp;

// 1780. Check if Number is a Sum of Powers of Three
// https://leetcode.com/problems/check-if-number-is-a-sum-of-powers-of-three
public class S01780
{
    public bool CheckPowersOfThree(int n)
    {
        while (n > 0 && n % 3 != 2)
        {
            n = n % 3 == 1 ? n - 1 : n / 3;
        }

        return n == 0;
    }
}
