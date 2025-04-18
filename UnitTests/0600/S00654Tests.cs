﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00654Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00654();
        Assert.That(sut.ConstructMaximumBinaryTree(new[] { 3,2,1,6,0,5}).AsString(), Is.EqualTo("[6,3,5,null,2,0,null,null,1]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00654();
        Assert.That(sut.ConstructMaximumBinaryTree(new[] {3,2,1 }).AsString(), Is.EqualTo("[3,null,2,null,1]"));
    }
}