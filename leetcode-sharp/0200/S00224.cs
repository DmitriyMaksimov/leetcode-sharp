namespace leetcode_sharp;

// 224. Basic Calculator
// https://leetcode.com/problems/basic-calculator/description/
public class S00224
{
    public int Calculate(string s)
    {
        var stack = new Stack<int>();
        var result = 0;
        var number = 0;
        var sign = 1;

        foreach (var c in s)
        {
            switch (c)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    number = 10 * number + (c - '0');
                    break;
                case '+':
                case '-':
                    result += sign * number;
                    number = 0;
                    sign = c == '+' ? 1 : -1;
                    break;
                case '(':
                    stack.Push(result);
                    stack.Push(sign);
                    //reset the sign and result for the value in the parenthesis
                    sign = 1;
                    result = 0;
                    break;
                case ')':
                    result += sign * number;
                    number = 0;
                    result *= stack.Pop();
                    result += stack.Pop();
                    break;
            }
        }

        result += sign * number;
        return result;
    }
}