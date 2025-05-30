﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02317Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02317();
        Assert.That(sut.MaximumXOR(new[] {3, 2, 4, 6}), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02317();
        Assert.That(sut.MaximumXOR(new[] {1, 2, 3, 9, 2}), Is.EqualTo(11));
    }
}