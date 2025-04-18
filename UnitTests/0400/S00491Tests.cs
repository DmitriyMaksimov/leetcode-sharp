﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00491Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00491();
        var expectation = new[] {new[] {4, 6}, new[] {4, 6, 7}, new[] {4, 6, 7, 7}, new[] {4, 7}, new[] {4, 7, 7}, new[] {6, 7}, new[] {6, 7, 7}, new[] {7, 7}};
        var result = sut.FindSubsequences(new[] {4, 6, 7, 7});
        Assert.That(result, Has.Count.EqualTo(expectation.Length));
        foreach (var e in expectation)
        {
            Assert.That(result, Does.Contain(e));
        }
    }

    [Test]
    public void T2()
    {
        var sut = new S00491();
        Assert.That(sut.FindSubsequences(new[] {4, 4, 3, 2, 1}), Is.EquivalentTo(new[] {new[] {4, 4}}));
    }

    [Test]
    public void T3()
    {
        var sut = new S00491();
        Assert.That(sut.FindSubsequences(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}), Has.Count.EqualTo(32752));
    }
}
