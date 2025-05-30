﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02506Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02506();
        Assert.That(sut.SimilarPairs(new[] {"aba", "aabb", "abcd", "bac", "aabc"}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02506();
        Assert.That(sut.SimilarPairs(new[] {"aabb", "ab", "ba"}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02506();
        Assert.That(sut.SimilarPairs(new[] {"nba", "cba", "dba"}), Is.EqualTo(0));
    }
}