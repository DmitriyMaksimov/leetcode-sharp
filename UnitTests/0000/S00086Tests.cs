﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00086Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00086();
        sut.Partition(ListNode.Parse("[1,4,3,2,5,2]"), 3).Should().BeEquivalentTo(ListNode.Parse("[1,2,2,4,3,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00086();
        sut.Partition(ListNode.Parse("[2,1]"), 2).Should().BeEquivalentTo(ListNode.Parse("[1,2]"));
    }
}