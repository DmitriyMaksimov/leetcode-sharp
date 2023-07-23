﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00036Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00036();
        sut.IsValidSudoku(new[]
        {
            new[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
            new[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            new[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
        }).Should().BeTrue();
    }
}