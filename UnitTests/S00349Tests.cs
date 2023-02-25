﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00349Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00349();
        sut.Intersection(new[] {1, 2, 2, 1}, new[] {2, 2}).Should().Equal(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00349();
        sut.Intersection(new[] {4, 9, 5}, new[] {9, 4, 9, 8, 4}).OrderBy(x => x).Should().Equal(4, 9);
    }
}