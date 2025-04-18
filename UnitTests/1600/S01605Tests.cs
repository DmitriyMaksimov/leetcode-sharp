﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01605Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01605();
        Assert.That(sut.RestoreMatrix([3, 8], [4, 7]), Is.EquivalentTo((int[][]) [[3, 0], [1, 7]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01605();
        Assert.That(sut.RestoreMatrix([5, 7, 10], [8, 6, 8]), Is.EquivalentTo((int[][]) [[5, 0, 0], [3, 4, 0], [0, 2, 8]]));
    }
}
