﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02373Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02373();
        var result = sut.LargestLocal(new[] {new[] {9, 9, 8, 1}, new[] {5, 6, 2, 6}, new[] {8, 2, 6, 4}, new[] {6, 2, 2, 2}});
        result[0].Should().Equal(9, 9);
        result[1].Should().Equal(8, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02373();
        var result = sut.LargestLocal(new[] {new[] {1, 1, 1, 1, 1}, new[] {1, 1, 1, 1, 1}, new[] {1, 1, 2, 1, 1}, new[] {1, 1, 1, 1, 1}, new[] {1, 1, 1, 1, 1}});
        result[0].Should().Equal(2, 2, 2);
        result[1].Should().Equal(2, 2, 2);
        result[2].Should().Equal(2, 2, 2);
    }
}