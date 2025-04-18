﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02960Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02960();
        Assert.That(sut.CountTestedDevices(new[] {1, 1, 2, 1, 3}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02960();
        Assert.That(sut.CountTestedDevices(new[] {0, 1, 2}), Is.EqualTo(2));
    }
}