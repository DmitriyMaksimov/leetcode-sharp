﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00092Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00092();
        sut.ReverseBetween(ListNode.Parse("[1,2,3,4,5]"), 2, 4).Should().BeEquivalentTo(ListNode.Parse("[1,4,3,2,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00092();
        sut.ReverseBetween(ListNode.Parse("[5]"), 1, 1).Should().BeEquivalentTo(ListNode.Parse("[5]"));
    }
}