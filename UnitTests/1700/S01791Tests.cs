﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01791Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01791();
        Assert.That(sut.FindCenter(new[] {new[] {1, 2}, new[] {2, 3}, new[] {4, 2}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01791();
        Assert.That(sut.FindCenter(new[] {new[] {1, 2}, new[] {5, 1}, new[] {1, 3}, new[] {1, 4}}), Is.EqualTo(1));
    }
}