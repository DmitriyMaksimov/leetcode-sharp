﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00740Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00740();
        sut.DeleteAndEarn(new[] {3, 4, 2}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00740();
        sut.DeleteAndEarn(new[] {2, 2, 3, 3, 3, 4}).Should().Be(9);
    }
}