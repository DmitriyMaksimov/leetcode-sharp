﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00561Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00561();
        Assert.That(sut.ArrayPairSum(new[] {1, 4, 3, 2}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00561();
        Assert.That(sut.ArrayPairSum(new[] {6, 2, 6, 5, 1, 2}), Is.EqualTo(9));
    }
}