﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00203Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00203();
        ListNode.ToString(sut.RemoveElements(ListNode.Parse("[1,2,6,3,4,5,6]"), 6)).Should().Be("[1,2,3,4,5]");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00203();
        sut.RemoveElements(null, 1).Should().BeNull();
    }

    [Test]
    public void T3()
    {
        var sut = new S00203();
        sut.RemoveElements(ListNode.Parse("[7,7,7,7]"), 7).Should().BeNull();
    }
}