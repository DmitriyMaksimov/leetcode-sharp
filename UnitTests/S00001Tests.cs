﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00001Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00001();
        sut.TwoSum(new[] {2, 7, 11, 15}, 9).Should().Equal(0, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00001();
        sut.TwoSum(new[] {3, 2, 4}, 6).Should().Equal(1, 2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00001();
        sut.TwoSum(new[] {3, 3}, 6).Should().Equal(0, 1);
    }
}