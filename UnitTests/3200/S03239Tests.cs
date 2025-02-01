using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03239Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03239();
        Assert.That(sut.MinFlips([[1, 0, 0], [0, 0, 0], [0, 0, 1]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03239();
        Assert.That(sut.MinFlips([[0, 1], [0, 1], [0, 0]]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03239();
        Assert.That(sut.MinFlips([[1], [0]]), Is.EqualTo(0));
    }
}
