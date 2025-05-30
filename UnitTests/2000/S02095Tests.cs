﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02095Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02095();
        Assert.That(sut.DeleteMiddle(ListNode.Parse("[1,3,4,7,1,2,6]")).AsString(), Is.EqualTo("[1,3,4,1,2,6]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02095();
        Assert.That(sut.DeleteMiddle(ListNode.Parse("[1,2,3,4]")).AsString(), Is.EqualTo("[1,2,4]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02095();
        Assert.That(sut.DeleteMiddle(ListNode.Parse("[2,1]")).AsString(), Is.EqualTo("[2]"));
    }
}