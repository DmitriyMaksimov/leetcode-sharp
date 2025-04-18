﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00500Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00500();
        Assert.That(sut.FindWords(new[] {"Hello", "Alaska", "Dad", "Peace"}), Is.EqualTo((string[]) ["Alaska", "Dad"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00500();
        Assert.That(sut.FindWords(new[] {"omk"}), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S00500();
        Assert.That(sut.FindWords(new[] {"adsdf", "sfd"}), Is.EqualTo((string[]) ["adsdf", "sfd"]));
    }

    [Test]
    public void T4()
    {
        var sut = new S00500();
        Assert.That(sut.FindWords(new[] {"a", "b"}), Is.EqualTo((string[]) ["a", "b"]));
    }

    [Test]
    public void T5()
    {
        var sut = new S00500();
        Assert.That(sut.FindWords(new[] {"qz", "wq", "asdddafadsfa", "adfadfadfdassfawde"}), Is.EqualTo((string[]) ["wq", "asdddafadsfa"]));
    }
}
