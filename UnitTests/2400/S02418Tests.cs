﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02418Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02418();
        Assert.That(sut.SortPeople(new[] {"Mary", "John", "Emma"}, new[] {180, 165, 170}), Is.EqualTo((string[]) ["Mary", "Emma", "John"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02418();
        Assert.That(sut.SortPeople(new[] {"Alice", "Bob", "Bob"}, new[] {155, 185, 150}), Is.EqualTo((string[]) ["Bob", "Alice", "Bob"]));
    }
}
