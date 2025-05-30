﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01519Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01519();
        Assert.That(sut.CountSubTrees(7, new[] {new[] {0, 1}, new[] {0, 2}, new[] {1, 4}, new[] {1, 5}, new[] {2, 3}, new[] {2, 6}}, "abaedcd"), Is.EqualTo((int[]) [2, 1, 1, 1, 1, 1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01519();
        Assert.That(sut.CountSubTrees(4, new[] {new[] {0, 1}, new[] {1, 2}, new[] {0, 3}}, "bbbb"), Is.EqualTo((int[]) [4, 2, 1, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01519();
        Assert.That(sut.CountSubTrees(5, new[] {new[] {0, 1}, new[] {0, 2}, new[] {1, 3}, new[] {0, 4}}, "aabab"), Is.EqualTo((int[]) [3, 2, 1, 1, 1]));
    }

    [Test]
    public void T4()
    {
        var sut = new S01519();
        Assert.That(sut.CountSubTrees(7, new[] {new[] {0, 1}, new[] {1, 2}, new[] {2, 3}, new[] {3, 4}, new[] {4, 5}, new[] {5, 6}}, "aaabaaa"), Is.EqualTo((int[]) [6, 5, 4, 1, 3, 2, 1]));
    }
}