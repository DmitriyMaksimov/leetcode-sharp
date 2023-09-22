﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02347Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02347();
        sut.BestHand(new[] {13, 2, 3, 1, 9}, new[] {'a', 'a', 'a', 'a', 'a', 'a'}).Should().Be("Flush");
    }

    [Test]
    public void T2()
    {
        var sut = new S02347();
        sut.BestHand(new[] {4, 4, 2, 4, 4}, new[] {'d', 'a', 'a', 'b', 'c'}).Should().Be("Three of a Kind");
    }

    [Test]
    public void T3()
    {
        var sut = new S02347();
        sut.BestHand(new[] {10, 10, 2, 12, 9}, new[] {'a', 'b', 'c', 'a', 'd'}).Should().Be("Pair");
    }
}