﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01406Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01406();
        sut.StoneGameIII(new[] {1,2,3,7}).Should().Be("Bob");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01406();
        sut.StoneGameIII(new[] {1,2,3,-9}).Should().Be("Alice");
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01406();
        sut.StoneGameIII(new[] {1,2,3,6}).Should().Be("Tie");
    }
}
