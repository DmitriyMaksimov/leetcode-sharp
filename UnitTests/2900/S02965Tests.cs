﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02965Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02965();
        Assert.That(sut.FindMissingAndRepeatedValues(new[] {new[] {1, 3}, new[] {2, 2}}), Is.EqualTo((int[]) [2, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02965();
        Assert.That(sut.FindMissingAndRepeatedValues(new[] {new[] {9, 1, 7}, new[] {8, 9, 2}, new[] {3, 4, 6}}), Is.EqualTo((int[]) [9, 5]));
    }
}