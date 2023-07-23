﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01376Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01376();
        sut.NumOfMinutes(1, 0, new[] {-1}, new[] {0}).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S01376();
        sut.NumOfMinutes(6, 2, new[] {2, 2, -1, 2, 2, 2}, new[] {0, 0, 1, 0, 0, 0}).Should().Be(1);
    }
}