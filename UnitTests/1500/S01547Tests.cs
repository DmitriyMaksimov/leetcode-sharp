﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01547Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01547();
        Assert.That(sut.MinCost(7, new[] {1, 3, 4, 5}), Is.EqualTo(16));
    }

    [Test]
    public void T2()
    {
        var sut = new S01547();
        Assert.That(sut.MinCost(9, new[] {5, 6, 1, 4, 2}), Is.EqualTo(22));
    }
}