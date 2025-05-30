﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01382Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01382();
        Assert.That(sut.BalanceBST(TreeNode.Parse("[1,null,2,null,3,null,4,null,null]")).AsString(), Is.EqualTo("[2,1,3,null,null,null,4]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01382();
        Assert.That(sut.BalanceBST(TreeNode.Parse("[2,1,3]")).AsString(), Is.EqualTo("[2,1,3]"));
    }
}