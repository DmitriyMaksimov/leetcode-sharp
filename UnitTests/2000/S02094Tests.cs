﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02094Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02094();
        Assert.That(sut.FindEvenNumbers(new[] {2, 1, 3, 0}), Is.EqualTo((int[]) [102, 120, 130, 132, 210, 230, 302, 310, 312, 320]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02094();
        Assert.That(sut.FindEvenNumbers(new[] {2, 2, 8, 8, 2}), Is.EqualTo((int[]) [222, 228, 282, 288, 822, 828, 882]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02094();
        Assert.That(sut.FindEvenNumbers(new[] {3, 7, 5}), Is.Empty);
    }
}