﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01035Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01035();
        Assert.That(sut.MaxUncrossedLines(new[] {1, 4, 2}, new[] {1, 2, 4}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01035();
        Assert.That(sut.MaxUncrossedLines(new[] {2, 5, 1, 2, 5}, new[] {10, 5, 2, 1, 5, 2}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01035();
        Assert.That(sut.MaxUncrossedLines(new[] {1, 3, 7, 1, 7, 5}, new[] {1, 9, 2, 5, 1}), Is.EqualTo(2));
    }
}