﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00014Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00014();
        Assert.That(sut.LongestCommonPrefix(new[] {"flower", "flow", "flight"}), Is.EqualTo("fl"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00014();
        Assert.That(sut.LongestCommonPrefix(new[] {"dog", "racecar", "car"}), Is.EqualTo(""));
    }
}