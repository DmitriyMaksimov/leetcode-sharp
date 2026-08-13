namespace leetcode_sharp;

// 2213. Longest Substring of One Repeating Character
// https://leetcode.com/problems/longest-substring-of-one-repeating-character
public class S02213
{
    private sealed record Node(char LeftChar, char RightChar, int Length, int Prefix, int Suffix, int Best);
    private Node[] _tree = [];

    private static Node Merge(Node left, Node right)
    {
        var length = left.Length + right.Length;

        var prefix = left.Prefix;
        if (left.RightChar == right.LeftChar && left.Prefix == left.Length)
        {
            prefix = left.Length + right.Prefix;
        }

        var suffix = right.Suffix;
        if (left.RightChar == right.LeftChar && right.Suffix == right.Length)
        {
            suffix = right.Length + left.Suffix;
        }

        var best = Math.Max(left.Best, right.Best);

        if (left.RightChar == right.LeftChar)
        {
            best = Math.Max(best, left.Suffix + right.Prefix);
        }

        return new Node(left.LeftChar, right.RightChar, length, prefix, suffix, best);
    }

    private void Build(int node, int start, int end, string s)
    {
        if (start == end)
        {
            var c = s[start];
            _tree[node] = new Node(c, c, 1, 1, 1, 1);
            return;
        }

        var mid = start + (end - start) / 2;

        Build(node * 2, start, mid, s);
        Build(node * 2 + 1, mid + 1, end, s);

        _tree[node] = Merge(_tree[node * 2], _tree[node * 2 + 1]);
    }

    private void Update(int node, int start, int end, int index, char ch)
    {
        if (start == end)
        {
            _tree[node] = new Node(ch, ch, 1, 1, 1, 1);
            return;
        }

        var mid = start + (end - start) / 2;

        if (index <= mid)
        {
            Update(node * 2, start, mid, index, ch);
        }
        else
        {
            Update(node * 2 + 1, mid + 1, end, index, ch);
        }

        _tree[node] = Merge(_tree[node * 2], _tree[node * 2 + 1]);
    }

    public int[] LongestRepeating(string s, string queryCharacters, int[] queryIndices)
    {
        var n = s.Length;

        _tree = new Node[4 * n];

        Build(1, 0, n - 1, s);

        var answer = new int[queryIndices.Length];

        for (var i = 0; i < queryIndices.Length; i++)
        {
            Update(1, 0, n - 1, queryIndices[i], queryCharacters[i]);
            answer[i] = _tree[1].Best;
        }

        return answer;
    }
}
