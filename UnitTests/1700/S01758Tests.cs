﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01758Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01758();
        Assert.That(sut.MinOperations("0100"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01758();
        Assert.That(sut.MinOperations("10"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01758();
        Assert.That(sut.MinOperations("1111"), Is.EqualTo(2));
    }
}