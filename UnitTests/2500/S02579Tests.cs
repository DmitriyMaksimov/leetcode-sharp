using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02579Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02579();
        Assert.That(sut.ColoredCells(1), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02579();
        Assert.That(sut.ColoredCells(2), Is.EqualTo(5));
    }
}
