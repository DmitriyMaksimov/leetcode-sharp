﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01700Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01700();
        sut.CountStudents(new[] {1, 1, 0, 0}, new[] {0, 1, 0, 1}).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S01700();
        sut.CountStudents(new[] {1, 1, 1, 0, 0, 1}, new[] {1, 0, 0, 0, 1, 1}).Should().Be(3);
    }
}