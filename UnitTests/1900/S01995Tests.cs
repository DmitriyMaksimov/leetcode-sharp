﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01995Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01995();
        sut.CountQuadruplets(new[] {1, 2, 3, 6}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01995();
        sut.CountQuadruplets(new[] {3, 3, 6, 4, 5}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01995();
        sut.CountQuadruplets(new[] {1, 1, 1, 3, 5}).Should().Be(4);
    }
}