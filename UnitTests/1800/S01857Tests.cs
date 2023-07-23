﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01857Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01857();
        sut.LargestPathValue("abaca", new[] {new[] {0, 1}, new[] {0, 2}, new[] {2, 3}, new[] {3, 4}}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01857();
        sut.LargestPathValue("a", new[] {new[] {0, 0}}).Should().Be(-1);
    }
}