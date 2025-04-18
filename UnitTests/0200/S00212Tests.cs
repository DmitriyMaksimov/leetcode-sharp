﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00212Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00212();
        var board = new[]
        {
            new[] {'o', 'a', 'a', 'n'},
            new[] {'e', 't', 'a', 'e'},
            new[] {'i', 'h', 'k', 'r'},
            new[] {'i', 'f', 'l', 'v'}
        };
        Assert.That(sut.FindWords(board, new[] {"oath", "pea", "eat", "rain"}), Is.EquivalentTo((string[]) ["eat", "oath"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00212();
        var board = new[]
        {
            new[] {'a', 'b'},
            new[] {'c', 'd'},
        };
        Assert.That(sut.FindWords(board, new[] {"abcb"}), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S00212();
        var board = new[]
        {
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'},
            new[] {'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'}
        };

        Assert.That(sut.FindWords(board,
            new[]
            {
                "lllllll", "fffffff", "ssss", "s", "rr", "xxxx", "ttt", "eee", "ppppppp", "iiiiiiiii", "xxxxxxxxxx",
                "pppppp", "xxxxxx", "yy", "jj", "ccc", "zzz", "ffffffff", "r", "mmmmmmmmm", "tttttttt", "mm", "ttttt",
                "qqqqqqqqqq", "z", "aaaaaaaa", "nnnnnnnnn", "v", "g", "ddddddd", "eeeeeeeee", "aaaaaaa", "ee", "n",
                "kkkkkkkkk", "ff", "qq", "vvvvv", "kkkk", "e", "nnn", "ooo", "kkkkk", "o", "ooooooo", "jjj", "lll",
                "ssssssss", "mmmm", "qqqqq", "gggggg", "rrrrrrrrrr", "iiii", "bbbbbbbbb", "aaaaaa", "hhhh", "qqq",
                "zzzzzzzzz", "xxxxxxxxx", "ww", "iiiiiii", "pp", "vvvvvvvvvv", "eeeee", "nnnnnnn", "nnnnnn", "nn",
                "nnnnnnnn", "wwwwwwww", "vvvvvvvv", "fffffffff", "aaa", "p", "ddd", "ppppppppp", "fffff", "aaaaaaaaa",
                "oooooooo", "jjjj", "xxx", "zz", "hhhhh", "uuuuu", "f", "ddddddddd", "zzzzzz", "cccccc", "kkkkkk",
                "bbbbbbbb", "hhhhhhhhhh", "uuuuuuu", "cccccccccc", "jjjjj", "gg", "ppp", "ccccccccc", "rrrrrr", "c",
                "cccccccc", "yyyyy", "uuuu", "jjjjjjjj", "bb", "hhh", "l", "u", "yyyyyy", "vvv", "mmm", "ffffff",
                "eeeeeee", "qqqqqqq", "zzzzzzzzzz", "ggg", "zzzzzzz", "dddddddddd", "jjjjjjj", "bbbbb", "ttttttt",
                "dddddddd", "wwwwwww", "vvvvvv", "iii", "ttttttttt", "ggggggg", "xx", "oooooo", "cc", "rrrr", "qqqq",
                "sssssss", "oooo", "lllllllll", "ii", "tttttttttt", "uuuuuu", "kkkkkkkk", "wwwwwwwwww", "pppppppppp",
                "uuuuuuuu", "yyyyyyy", "cccc", "ggggg", "ddddd", "llllllllll", "tttt", "pppppppp", "rrrrrrr", "nnnn",
                "x", "yyy", "iiiiiiiiii", "iiiiii", "llll", "nnnnnnnnnn", "aaaaaaaaaa", "eeeeeeeeee", "m", "uuu",
                "rrrrrrrr", "h", "b", "vvvvvvv", "ll", "vv", "mmmmmmm", "zzzzz", "uu", "ccccccc", "xxxxxxx", "ss",
                "eeeeeeee", "llllllll", "eeee", "y", "ppppp", "qqqqqq", "mmmmmm", "gggg", "yyyyyyyyy", "jjjjjj",
                "rrrrr", "a", "bbbb", "ssssss", "sss", "ooooo", "ffffffffff", "kkk", "xxxxxxxx", "wwwwwwwww", "w",
                "iiiiiiii", "ffff", "dddddd", "bbbbbb", "uuuuuuuuu", "kkkkkkk", "gggggggggg", "qqqqqqqq", "vvvvvvvvv",
                "bbbbbbbbbb", "nnnnn", "tt", "wwww", "iiiii", "hhhhhhh", "zzzzzzzz", "ssssssssss", "j", "fff",
                "bbbbbbb", "aaaa", "mmmmmmmmmm", "jjjjjjjjjj", "sssss", "yyyyyyyy", "hh", "q", "rrrrrrrrr", "mmmmmmmm",
                "wwwww", "www", "rrr", "lllll", "uuuuuuuuuu", "oo", "jjjjjjjjj", "dddd", "pppp", "hhhhhhhhh", "kk",
                "gggggggg", "xxxxx", "vvvv", "d", "qqqqqqqqq", "dd", "ggggggggg", "t", "yyyy", "bbb", "yyyyyyyyyy",
                "tttttt", "ccccc", "aa", "eeeeee", "llllll", "kkkkkkkkkk", "sssssssss", "i", "hhhhhh", "oooooooooo",
                "wwwwww", "ooooooooo", "zzzz", "k", "hhhhhhhh", "aaaaa", "mmmmm"
            }), Is.EqualTo((string[]) ["aaaaaaaa", "aaaaaaa", "aaaaaa", "aaa", "aaaaaaaaa", "aaaaaaaaaa", "a", "aaaa", "aa",
        "aaaaa"]));
    }
}
