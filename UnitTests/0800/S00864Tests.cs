﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00864Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00864();
        Assert.That(sut.ShortestPathAllKeys(new[] {"@.a..", "###.#", "b.A.B"}), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S00864();
        Assert.That(sut.ShortestPathAllKeys(new[] {"@..aA", "..B#.", "....b"}), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S00864();
        Assert.That(sut.ShortestPathAllKeys(new[] {"@Aa"}), Is.EqualTo(-1));
    }
}