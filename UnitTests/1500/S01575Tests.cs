using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01575Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01575();
        sut.CountRoutes(new[] {2, 3, 6, 8, 4}, 1, 3, 5).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01575();
        sut.CountRoutes(new[] {4, 3, 1}, 1, 0, 6).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01575();
        sut.CountRoutes(new[] {5, 2, 1}, 0, 2, 3).Should().Be(0);
    }
}