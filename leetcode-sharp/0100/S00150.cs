namespace leetcode_sharp;

// 150. Evaluate Reverse Polish Notation
// https://leetcode.com/problems/evaluate-reverse-polish-notation/
public class S00150
{
    private Stack<int> _stack = new();
    private HashSet<string> _operations = ["+", "-", "*", "/"];

    public int EvalRPN(string[] tokens)
    {
        foreach (var token in tokens)
        {
            if (_operations.Contains(token))
            {
                var l = _stack.Pop();
                var r = _stack.Pop();
                var result = token switch
                {
                    "+" => r + l,
                    "*" => r * l,
                    "-" => r - l,
                    "/" => r / l,
                    _ => throw new ArgumentException("") 
                };
                _stack.Push(result);
            }
            else
            {
                _stack.Push(int.Parse(token));
            }
        }

        return _stack.Pop();
    }
}