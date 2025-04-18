﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00847Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00847();
        Assert.That(sut.ShortestPathLength(new[] {new[] {1, 2, 3}, new[] {0}, new[] {0}, new[] {0}}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00847();
        Assert.That(sut.ShortestPathLength(new[] {new[] {1}, new[] {0, 2, 4}, new[] {1, 3, 4}, new[] {2}, new[] {1, 2}}), Is.EqualTo(4));
    }
}