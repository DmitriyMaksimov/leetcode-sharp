﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00128Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00128();
        sut.LongestConsecutive(new[] {100, 4, 200, 1, 3, 2}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00128();
        sut.LongestConsecutive(new[] {0, 3, 7, 2, 5, 8, 4, 6, 0, 1}).Should().Be(9);
    }
}