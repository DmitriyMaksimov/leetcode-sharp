﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S100230Tests
{
    [Test]
    public void T1()
    {
        var sut = new S100230();
        sut.ModifiedMatrix([[1, 2, -1], [4, -1, 6], [7, 8, 9]]).Should().BeEquivalentTo([(int[]) [1, 2, 9], [4, 8, 6], [7, 8, 9]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S100230();
        sut.ModifiedMatrix([[3, -1], [5, 2]]).Should().BeEquivalentTo([(int[]) [3, 2], [5, 2]]);
    }
}