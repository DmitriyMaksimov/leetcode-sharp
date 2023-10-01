﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02600Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02600();
        sut.KItemsWithMaximumSum(3, 2, 0, 2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02600();
        sut.KItemsWithMaximumSum(3, 2, 0, 4).Should().Be(3);
    }
}