﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00151Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00151();
        Assert.That(sut.ReverseWords("the sky is blue"), Is.EqualTo("blue is sky the"));
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00151();
        Assert.That(sut.ReverseWords("  hello world  "), Is.EqualTo("world hello"));
    }
    
    [Test]
    public void Test3()
    {
        var sut = new S00151();
        Assert.That(sut.ReverseWords("a good   example"), Is.EqualTo("example good a"));
    }
}