﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00455Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00455();
        sut.FindContentChildren(new[] {1, 2, 3}, new[] {1, 1}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00455();
        sut.FindContentChildren(new[] {1, 2}, new[] {1, 2, 3}).Should().Be(2);
    }
}