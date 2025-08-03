namespace leetcode_sharp;

// 394. Decode String
// https://leetcode.com/problems/decode-string/
public class S00394
{
    public string DecodeString(string s)
    {
        var stack = new Stack<char>();

        foreach (var ch in s)
        {
            var temp = "";
            var temp2 = "";

            if (ch != ']')
            {
                stack.Push(ch);
                continue;
            }

            while (stack.Count != 0 && char.IsLetter(stack.Peek()))
            {
                temp += stack.Pop();
            }

            stack.Pop();

            temp = new string(temp.Reverse().ToArray());

            while (stack.Count != 0 && char.IsDigit(stack.Peek()))
            {
                temp2 += stack.Pop();
            }

            temp2 = new string(temp2.Reverse().ToArray());

            var n = int.Parse(temp2);
            temp2 = temp;

            while (--n > 0)
            {
                temp += temp2;
            }

            foreach (var c in temp)
            {
                stack.Push(c);
            }
        }

        return new string(stack.Reverse().ToArray());
    }
}