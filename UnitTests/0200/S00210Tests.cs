﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00210Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00210();
        Assert.That(sut.FindOrder(2, new[] {new[] {1, 0}}), Is.EqualTo((int[]) [0, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00210();
        Assert.That(sut.FindOrder(4, new[] {new[] {1, 0}, new[] {2, 0}, new[] {3, 1}, new[] {3, 2}}), Is.EqualTo((int[]) [0, 2, 1, 3]));
    }
}