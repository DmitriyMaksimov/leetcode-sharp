using System.Text;

namespace leetcode_sharp;

// 402. Remove K Digits
// https://leetcode.com/problems/remove-k-digits
public class S00402
{
    public string RemoveKdigits(string num, int k)
    {
        var len = num.Length;

        if (k == len)
        {
            return "0";
        }

        Stack<char> stack = [];

        var i = 0;
        while (i < num.Length)
        {
            while (k > 0 && stack.Any() && stack.Peek() > num[i])
            {
                stack.Pop();
                k--;
            }

            stack.Push(num[i]);
            i++;
        }

        while (k > 0)
        {
            stack.Pop();
            k--;
        }

        var s = new string(stack.Reverse().ToArray());

        // Remove leading '0's
        while (s.Length > 1 && s[0] == '0')
        {
            s = s[1..];
        }

        return s;
    }
}