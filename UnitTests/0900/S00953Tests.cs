﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00953Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00953();
        Assert.That(sut.IsAlienSorted(new[] {"hello", "leetcode"}, "hlabcdefgijkmnopqrstuvwxyz"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00953();
        Assert.That(sut.IsAlienSorted(new[] {"word","world","row"}, "worldabcefghijkmnpqstuvxyz"), Is.False);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00953();
        Assert.That(sut.IsAlienSorted(new[] {"apple","app"}, "abcdefghijklmnopqrstuvwxyz"), Is.False);
    }
}
