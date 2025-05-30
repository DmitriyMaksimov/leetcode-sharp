﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02415Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02415();
        Assert.That(sut.ReverseOddLevels(TreeNode.Parse("[2,3,5,8,13,21,34]")).AsString(), Is.EqualTo("[2,5,3,8,13,21,34]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02415();
        Assert.That(sut.ReverseOddLevels(TreeNode.Parse("[7,13,11]")).AsString(), Is.EqualTo("[7,11,13]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02415();
        Assert.That(sut.ReverseOddLevels(TreeNode.Parse("[0,1,2,0,0,0,0,1,1,1,1,2,2,2,2]")).AsString(), Is.EqualTo("[0,2,1,0,0,0,0,2,2,2,2,1,1,1,1]"));
    }
}