﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00303Tests
{
    [Test]
    public void T1()
    {
        var numArray = new S00303.NumArray(new[] {-2, 0, 3, -5, 2, -1});
        numArray.SumRange(0, 2).Should().Be(1);
        numArray.SumRange(2, 5).Should().Be(-1);
        numArray.SumRange(0, 5).Should().Be(-3);
    }
}