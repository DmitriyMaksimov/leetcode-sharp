﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01493Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01493();
        Assert.That(sut.LongestSubarray(new[] {1, 1, 0, 1}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01493();
        Assert.That(sut.LongestSubarray(new[] {0, 1, 1, 1, 0, 1, 1, 0, 1}), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01493();
        Assert.That(sut.LongestSubarray(new[] {1, 1, 1}), Is.EqualTo(2));
    }
}