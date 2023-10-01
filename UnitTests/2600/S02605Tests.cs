﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02605Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02605();
        sut.MinNumber(new[] {4, 1, 3}, new[] {5, 7}).Should().Be(15);
    }

    [Test]
    public void T2()
    {
        var sut = new S02605();
        sut.MinNumber(new[] {3, 5, 2, 6}, new[] {3, 1, 7}).Should().Be(3);
    }
}