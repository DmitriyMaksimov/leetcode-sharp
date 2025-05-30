﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01631Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01631();
        Assert.That(sut.MinimumEffortPath(new[] {new[] {1, 2, 2}, new[] {3, 8, 2}, new[] {5, 3, 5}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01631();
        Assert.That(sut.MinimumEffortPath(new[] {new[] {1, 2, 3}, new[] {3, 8, 4}, new[] {5, 3, 5}}), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01631();
        Assert.That(sut.MinimumEffortPath(new[]
        {
            new[] {1, 2, 1, 1, 1},
            new[] {1, 2, 1, 2, 1},
            new[] {1, 2, 1, 2, 1},
            new[] {1, 2, 1, 2, 1},
            new[] {1, 1, 1, 2, 1}
        }), Is.EqualTo(0));
    }
}