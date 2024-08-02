using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02134Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02134();
        sut.MinSwaps([0, 1, 0, 1, 1, 0, 0]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02134();
        sut.MinSwaps([0, 1, 1, 1, 0, 0, 1, 1, 0]).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02134();
        sut.MinSwaps([1, 1, 0, 0, 1]).Should().Be(0);
    }
}
