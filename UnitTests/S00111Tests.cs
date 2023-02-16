﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00111Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00111();
        sut.MinDepth(TreeNode.Parse("[3,9,20,null,null,15,7]")).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00111();
        sut.MinDepth(TreeNode.Parse("[2,null,3,null,4,null,5,null,6]")).Should().Be(5);
    }
}