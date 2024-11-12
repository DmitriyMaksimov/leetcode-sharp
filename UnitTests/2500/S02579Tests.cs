using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02579Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02579();
        sut.ColoredCells(1).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02579();
        sut.ColoredCells(2).Should().Be(5);
    }
}
