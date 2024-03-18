namespace leetcode_sharp;

// 3079. Find the Sum of Encrypted Integers
// https://leetcode.com/problems/find-the-sum-of-encrypted-integers
public class S03079
{
    public int SumOfEncryptedInt(int[] nums)
    {
        var sum = 0;

        foreach (var num in nums)
        {
            var str = num.ToString();
            var max = str.ToCharArray().Max() - '0';
            var encrypted = max;

            for (var i = 0; i < str.Length - 1; i++)
            {
                encrypted *= 10;
                encrypted += max;
            }

            sum += encrypted;
        }

        return sum;
    }
}