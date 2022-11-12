using FluentAssertions;
using leetcode_sharp;
using NUnit.Framework;

namespace UnitTests;

[TestFixture]
public class S00035UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00035();
        sut.SearchInsert(new[] {1, 3, 5, 6}, 5).Should().Be(2);
    }

    [Test]
    public void Test2()
    {
        var sut = new S00035();
        sut.SearchInsert(new[] {1, 3, 5, 6}, 2).Should().Be(1);
    }

    [Test]
    public void Test3()
    {
        var sut = new S00035();
        sut.SearchInsert(new[] {1, 3, 5, 6}, 7).Should().Be(4);
    }
}