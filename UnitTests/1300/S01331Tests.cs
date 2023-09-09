﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01331Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01331();
        sut.ArrayRankTransform(new[] {40, 10, 20, 30}).Should().Equal(4, 1, 2, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01331();
        sut.ArrayRankTransform(new[] {100, 100, 100}).Should().Equal(1, 1, 1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01331();
        sut.ArrayRankTransform(new[] {37, 12, 28, 9, 100, 56, 80, 5, 12}).Should().Equal(5, 3, 4, 2, 8, 6, 7, 1, 3);
    }
}