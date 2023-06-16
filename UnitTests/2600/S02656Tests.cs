﻿using leetcode_sharp;

namespace UnitTests._2600;

[TestFixture]
public class S02656Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02656();
        sut.MaximizeSum(new[] {1, 2, 3, 4, 5}, 3).Should().Be(18);
    }

    [Test]
    public void T2()
    {
        var sut = new S02656();
        sut.MaximizeSum(new[] {5, 5, 5}, 2).Should().Be(11);
    }
}