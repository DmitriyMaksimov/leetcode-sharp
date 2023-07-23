﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00063Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00063();
        sut.UniquePathsWithObstacles(new[] {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {0, 0, 0}}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00063();
        sut.UniquePathsWithObstacles(new[] {new[] {0, 1}, new[] {0, 0}}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00063();
        sut.UniquePathsWithObstacles(new[] {new[] {0, 0}, new[] {0, 1}}).Should().Be(0);
    }

    [Test]
    public void T4()
    {
        var sut = new S00063();
        sut.UniquePathsWithObstacles(new[] {new[] {0, 0}, new[] {1, 1}, new[] {0, 0}}).Should().Be(0);
    }
}