﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00999Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00999();
        Assert.That(sut.NumRookCaptures(
            new[]
            {
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'R', '.', '.', '.', 'p'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'}
            }), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00999();
        Assert.That(sut.NumRookCaptures(
            new[]
            {
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', 'p', 'p', 'p', 'p', 'p', '.', '.'},
                new[] {'.', 'p', 'p', 'B', 'p', 'p', '.', '.'},
                new[] {'.', 'p', 'B', 'R', 'B', 'p', '.', '.'},
                new[] {'.', 'p', 'p', 'B', 'p', 'p', '.', '.'},
                new[] {'.', 'p', 'p', 'p', 'p', 'p', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'}
            }), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00999();
        Assert.That(sut.NumRookCaptures(
            new[]
            {
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'p', 'p', '.', 'R', '.', 'p', 'B', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'B', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'}
            }), Is.EqualTo(3));
    }
}