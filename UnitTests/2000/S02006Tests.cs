using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02006Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02006();
        sut.CountKDifference(new[] {1, 2, 2, 1}, 1).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02006();
        sut.CountKDifference(new[] {1, 3}, 3).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02006();
        sut.CountKDifference(new[] {3, 2, 1, 5, 4}, 2).Should().Be(3);
    }
}