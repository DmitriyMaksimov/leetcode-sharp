namespace leetcode_sharp;

// 3340. Check Balanced String
// https://leetcode.com/problems/check-balanced-string
public class S03340
{
    public bool IsBalanced(string num)
    {
        var oddSum = 0;
        var evenSum = 0;

        for (int i = 0; i < num.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += num[i] - '0';
            }
            else
            {
                oddSum += num[i] - '0';
            }
        }

        return oddSum == evenSum;
    }
}