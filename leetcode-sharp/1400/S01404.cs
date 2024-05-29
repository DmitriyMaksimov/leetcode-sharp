namespace leetcode_sharp;

// 1404. Number of Steps to Reduce a Number in Binary Representation to One
// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-in-binary-representation-to-one
public class S01404
{
    public int NumSteps(string s)
    {
        var res = 0;
        var carry = 0;

        for (var i = s.Length - 1; i > 0; --i)
        {
            ++res;
        
            if (s[i] - '0' + carry == 1)
            {
                carry = 1;
                ++res;
            }
        }

        return res + carry;
    }
}