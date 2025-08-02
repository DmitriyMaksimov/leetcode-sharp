using System.Text;

namespace leetcode_sharp;

// 212. Word Search II
// https://leetcode.com/problems/word-search-ii/
public class S00212
{
    private int _n;
    private int _m;
    private char[][] _board = null!;

    private bool isChar(int x, int y, char ch)
    {
        return x >= 0 && x < _m && y >= 0 && y < _n && _board[y][x] == ch;
    }

    private bool dfs(int x, int y, string s, int i)
    {
        if (i >= s.Length)
        {
            return true;
        }

        if (!isChar(x, y, s[i]))
        {
            return false;
        }

        _board[y][x] = '.';
        var res = dfs(x - 1, y, s, i + 1) ||
                  dfs(x + 1, y, s, i + 1) ||
                  dfs(x, y + 1, s, i + 1) ||
                  dfs(x, y - 1, s, i + 1);
        _board[y][x] = s[i];
        return res;
    }

    private static string reverseString(string s)
    {
        return new string(s.Reverse().ToArray());
    }

    private static bool shouldReverse(string s)
    {
        return s.Length > 5 && s[0] == s[1] && s[1] == s[2] && s[2] == s[3] && s[3] == s[4];
    }

    public IList<string> FindWords(char[][] board, string[] words)
    {
        _board = board;
        _n = _board.Length;
        _m = _board[0].Length;
        var p = new Dictionary<char, List<(int, int)>>();
        var chars = new HashSet<char>();
        for (var y = 0; y < _n; y++)
        {
            for (var x = 0; x < _m; x++)
            {
                if (!p.ContainsKey(_board[y][x]))
                {
                    p[_board[y][x]] = new List<(int, int)>();
                }

                p[_board[y][x]].Add((x, y));
                chars.Add(_board[y][x]);
            }
        }

        var reversed = new HashSet<int>();

        for (var i = 0; i < words.Length; i++)
        {
            if (shouldReverse(words[i]))
            {
                words[i] = reverseString(words[i]);
                reversed.Add(i);
            }
        }

        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].Count(x => !chars.Contains(x)) > 0)
            {
                words[i] = "";
            }
        }

        List<string> res = new List<string>();
        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].Length == 0)
            {
                continue;
            }

            for (var k = 0; k < p[words[i][0]].Count; k++)
            {
                if (dfs(p[words[i][0]][k].Item1, p[words[i][0]][k].Item2, words[i], 0))
                {
                    if (reversed.Contains(i))
                    {
                        words[i] = reverseString(words[i]);
                    }

                    res.Add(words[i]);
                    break;
                }
            }
        }

        return res;
    }
}