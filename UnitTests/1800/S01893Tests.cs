﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01893Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01893();
        Assert.That(sut.IsCovered(new[] {new[] {1, 2}, new[] {3, 4}, new[] {5, 6}}, 2, 5), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01893();
        Assert.That(sut.IsCovered(new[] {new[] {1, 10}, new[] {10, 20}}, 21, 21), Is.False);
    }
}
